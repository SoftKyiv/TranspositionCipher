using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TranspositionCipher
{
    public partial class GlobalCipherForm : Form
    {
        Transposition t;
        public GlobalCipherForm()
        {
            InitializeComponent();
            rusLanguageRadioBtn.Checked = true;
            outputTextBox.ReadOnly = true;
            MaximizeBox = false;
            t = new Transposition();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            t.SetKey(keyTextBox.Text);

            if (encryptRadioButton.Checked)
                outputTextBox.Text = t.Encrypt(inputTextBox.Text);
            else
                outputTextBox.Text = t.Decrypt(inputTextBox.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (lockedBox.Checked)
            {
                keyTextBox.ReadOnly = true;
                keyTextBox.Text = "2 1 4 3";
            }
            else
            {
                if (engLanguageRadioBtn.Checked)
                {
                    MessageBox.Show("Auto-Key has been unlocked!",
                                       "Change Settings", MessageBoxButtons.OK,
                                       MessageBoxIcon.Information,
                                       0);
                    keyTextBox.ReadOnly = false;
                    keyTextBox.Text = null;
                }
                else if (rusLanguageRadioBtn.Checked)
                {
                    MessageBox.Show("Авто-Ключ был разблокирован!",
                                   "Изменение настроек", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information,
                                   0);
                    keyTextBox.ReadOnly = false;
                    keyTextBox.Text = null;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (decryptRadioButton.Checked)
            {
                outputTextBox.Text = null;
            }
            else if (encryptRadioButton.Checked)
            {
                outputTextBox.Text = null;
            }
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (engLanguageRadioBtn.Checked)
            {
                DialogResult dialog = MessageBox.Show(
            "Are you sure you want to exit the program?",
            "End of the program",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    Process.GetCurrentProcess().Kill();
                    e.Cancel = false;
                }
                else if (dialog == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else if (rusLanguageRadioBtn.Checked)
            {
                DialogResult dialog = MessageBox.Show(
           "Вы уверены, что хотите выйти из программы?",
           "Завершение программы",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    Process.GetCurrentProcess().Kill();
                    e.Cancel = false;
                }
                else if (dialog == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = null;
            outputTextBox.Text = null;
        }

        private void rusLanguageRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Исходный текст";
            label2.Text = "Обработанный текст";
            groupBox1.Text = "Действие";
            encryptRadioButton.Text = "Зашифровать";
            decryptRadioButton.Text = "Расшифровать";
            button1.Text = "Очистить";
            startButton.Text = "Выполнить";
            label3.Text = "Ключ";
            lockedBox.Text = "Авто-Ключ";
        }

        private void engLanguageRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Original";
            label2.Text = "Processed Сontent";
            groupBox1.Text = "Act";
            encryptRadioButton.Text = "Encrypt";
            decryptRadioButton.Text = "Decrypt";
            button1.Text = "Clear";
            startButton.Text = "Execute";
            label3.Text = "Key";
            lockedBox.Text = "Auto-Key";
        }
    }
}