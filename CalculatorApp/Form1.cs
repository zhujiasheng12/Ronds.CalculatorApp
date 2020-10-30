using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculateForm : Form
    {
        //定义操作数与结果
        string firstValue, secondValue, resultValue;

        //记录上一次点击的计算操作按钮
        char operation;

        //存储了上次点击了什么按钮，0代表什么都没点，1代表了数字按钮
        private int _lastButtonStatus = 0;

        public CalculateForm()
        {
            InitializeComponent();
        }

        private void CalculateForm_Load(object sender, EventArgs e)
        {
            btn_zero.Click += new EventHandler(OnBtnVal_Click);
            btn_one.Click += new EventHandler(OnBtnVal_Click);
            btn_two.Click += new EventHandler(OnBtnVal_Click);
            btn_three.Click += new EventHandler(OnBtnVal_Click);
            btn_four.Click += new EventHandler(OnBtnVal_Click);
            btn_five.Click += new EventHandler(OnBtnVal_Click);
            btn_six.Click += new EventHandler(OnBtnVal_Click);
            btn_seven.Click += new EventHandler(OnBtnVal_Click);
            btn_eight.Click += new EventHandler(OnBtnVal_Click);
            btn_nine.Click += new EventHandler(OnBtnVal_Click);
            btn_point.Click += new EventHandler(OnBtnVal_Click);
        }

        /// <summary>
        /// 加法操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_Click(object sender, EventArgs e)
        {
            BtnCalculteFilter(sender, e);
            firstValue = textBox_result.Text;
            operation = '+';
            textBox_step.Text = $"{firstValue}+";
            textBox_result.Text = string.Empty;
        }

        /// <summary>
        /// 减法操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_sub_Click(object sender, EventArgs e)
        {
            BtnCalculteFilter(sender, e);
            firstValue = textBox_result.Text;
            operation = '-';
            textBox_step.Text = $"{firstValue}-";
            textBox_result.Text = string.Empty;
        }

        /// <summary>
        /// 乘法操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_mult_Click(object sender, EventArgs e)
        {
            BtnCalculteFilter(sender, e);
            firstValue = textBox_result.Text;
            operation = '*';
            textBox_step.Text = $"{firstValue}*";
            textBox_result.Text = string.Empty;
        }

        /// <summary>
        /// 除法操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_div_Click(object sender, EventArgs e)
        {
            BtnCalculteFilter(sender ,e);
            firstValue = textBox_result.Text;
            operation = '/';
            textBox_step.Text = $"{firstValue}/";
            textBox_result.Text = string.Empty;
        }

        /// <summary>
        /// 多个计算数连续计算
        /// </summary>
        private void BtnCalculteFilter(object sender, EventArgs e)
        {
            if (textBox_step.Text.EndsWith("+") || textBox_step.Text.EndsWith("-")
                    || textBox_step.Text.EndsWith("*") || textBox_step.Text.EndsWith("/"))
            {
                btn_equal_Click(sender, e);
            }
        }

        /// <summary>
        /// 归零操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox_step.Text = "0";
            textBox_result.Text = "0";
            firstValue = string.Empty;
            secondValue = string.Empty;
            _lastButtonStatus = 0;
        }

        /// <summary>
        /// 退格操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text.Length > 0)
            {
                textBox_result.Text = textBox_result.Text.Substring(0, textBox_result.Text.Length - 1);
            }
        }

        /// <summary>
        /// 等于操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_equal_Click(object sender, EventArgs e)
        {
            try
            {
                secondValue = textBox_result.Text;
                textBox_step.Text += $"{secondValue}=";

                double outFirst, outSecond;

                double.TryParse(firstValue, out outFirst);
                double.TryParse(secondValue, out outSecond);

                switch (operation)
                {
                    case '+':
                        resultValue = (outFirst + outSecond).ToString();
                        break;
                    case '-':
                        resultValue = (outFirst - outSecond).ToString();
                        break;
                    case '*':
                        resultValue = (outFirst * outSecond).ToString();
                        break;
                    case '/':
                        if (outSecond != 0)
                        {
                            resultValue = (outFirst / outSecond).ToString();
                        }
                        else
                        {
                            MessageBox.Show("被除数不能为0");
                        }

                        break;
                }

                textBox_result.Text = resultValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 数字按钮的点击记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBtnVal_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (_lastButtonStatus == 0 || textBox_result.Text == "0")
            {
                textBox_result.Text = btn.Text;
            }
            else
            {
                textBox_result.Text += btn.Text;
            }

            _lastButtonStatus = 1;
        }
    }
}
