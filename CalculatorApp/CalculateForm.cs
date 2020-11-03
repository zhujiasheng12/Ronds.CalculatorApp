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
    /// <summary>
    /// 功能介绍:计算器窗体
    /// 作者:朱家生
    /// 创建日期:2020.11.3
    /// </summary>
    public partial class CalculateForm : Form
    {
        //定义操作数与结果
        string firstValue, secondValue, resultValue;

        //记录上一次点击的计算操作按钮
        char operation;

        //上一次点击的是否为数字按钮
        private bool _lastButtonStatus = false;

        public CalculateForm()
        {
            InitializeComponent();
        }

        private void CalculateForm_Load(object sender, EventArgs e)
        {
            btnZero.Click += new EventHandler(OnBtnVal_Click);
            btnOne.Click += new EventHandler(OnBtnVal_Click);
            btnTwo.Click += new EventHandler(OnBtnVal_Click);
            btnThree.Click += new EventHandler(OnBtnVal_Click);
            btnFour.Click += new EventHandler(OnBtnVal_Click);
            btnFive.Click += new EventHandler(OnBtnVal_Click);
            btnSix.Click += new EventHandler(OnBtnVal_Click);
            btnSeven.Click += new EventHandler(OnBtnVal_Click);
            btnEight.Click += new EventHandler(OnBtnVal_Click);
            btnNine.Click += new EventHandler(OnBtnVal_Click);
            btnPoint.Click += new EventHandler(OnBtnVal_Click);
        }

        /// <summary>
        /// 多个计算数连续计算
        /// </summary>
        private void BtnCalculteFilter(object sender, EventArgs e)
        {
            _lastButtonStatus = false;

            if (textBoxStep.Text.EndsWith("+") || textBoxStep.Text.EndsWith("-")
                    || textBoxStep.Text.EndsWith("*") || textBoxStep.Text.EndsWith("/"))
            {
                btnEqualClick(sender, e);
            }
        }

        /// <summary>
        /// 归零操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearClick(object sender, EventArgs e)
        {
            textBoxStep.Text = "0";
            textBoxResult.Text = "0";
            firstValue = string.Empty;
            secondValue = string.Empty;
            _lastButtonStatus = false;
        }

        /// <summary>
        /// 退格操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteClick(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Length > 0)
            {
                textBoxResult.Text = textBoxResult.Text.Substring(0, textBoxResult.Text.Length - 1);
            }
        }

        /// <summary>
        /// 加法操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddClick(object sender, EventArgs e)
        {
            if (_lastButtonStatus == true)
            {
                BtnCalculteFilter(sender, e);
                firstValue = textBoxResult.Text;
                operation = '+';
                textBoxStep.Text = $"{firstValue}+";
                textBoxResult.Text = string.Empty;
            }
        }

        /// <summary>
        /// 减法操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubClick(object sender, EventArgs e)
        {
            if (_lastButtonStatus == true)
            {
                BtnCalculteFilter(sender, e);
                firstValue = textBoxResult.Text;
                operation = '-';
                textBoxStep.Text = $"{firstValue}-";
                textBoxResult.Text = string.Empty;
            }
        }

        /// <summary>
        /// 乘法操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMultClick(object sender, EventArgs e)
        {
            if (_lastButtonStatus == true)
            {
                BtnCalculteFilter(sender, e);
                firstValue = textBoxResult.Text;
                operation = '*';
                textBoxStep.Text = $"{firstValue}*";
                textBoxResult.Text = string.Empty;
            }
        }

        /// <summary>
        /// 除法操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDivClick(object sender, EventArgs e)
        {
            if (_lastButtonStatus == true)
            {
                BtnCalculteFilter(sender, e);
                firstValue = textBoxResult.Text;
                operation = '/';
                textBoxStep.Text = $"{firstValue}/";
                textBoxResult.Text = string.Empty;
            }
        }

        /// <summary>
        /// 等于操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEqualClick(object sender, EventArgs e)
        {
            try
            {
                secondValue = textBoxResult.Text;
                textBoxStep.Text += $"{secondValue}=";

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

                textBoxResult.Text = resultValue;
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

            if (_lastButtonStatus == false || textBoxResult.Text == "0")
            {
                textBoxResult.Text = btn.Text;
            }
            else
            {
                textBoxResult.Text += btn.Text;
            }

            _lastButtonStatus = true;
        }
    }
}
