using System.Runtime.CompilerServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string text = string.Empty;
        string font = string.Empty;
        string colorInFront = string.Empty;
        string colorBackground = string.Empty;
        string textAlign = string.Empty;
        int widthofbutton = 0;
        int heightofbutton = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Button tlacitko = button1;
            Form2 form = new Form2(tlacitko);
            form.ShowDialog();
        }
    }

    public partial class Form2 : Form
    {
        private TextBox textBox;
        private ComboBox fontComboBox;
        private ComboBox colorInFrontComboBox;
        private ComboBox colorBackgroundComboBox;
        private ComboBox textAlignComboBox;
        private NumericUpDown widthNumericUpDown;
        private NumericUpDown heightNumericUpDown;
        private NumericUpDown sizeoftext;
        private Button neco2;

        Label label1 = new Label();
        Label label2 = new Label();
        Label label3 = new Label();
        Label label4 = new Label();
        Label label5 = new Label();
        Label label6 = new Label();
        Label label7 = new Label();
        Label label8 = new Label();

        public Form2(Button tlacitko)
        {
            this.Size = new Size(800, 500);

            label1.Text = "Text";
            label1.Location = new Point(300, 20);

            this.Controls.Add(label1);

            label2.Text = "B-textu";
            label2.Location = new Point(300, 60);
            this.Controls.Add(label2);

            label3.Text = "B-popøedí";
            label3.Location = new Point(300, 100);
            this.Controls.Add(label3);

            label4.Text = "B-pozadí";
            label4.Location = new Point(300, 140);
            this.Controls.Add(label4);

            label5.Text = "T-strana";
            label5.Location = new Point(300, 180);
            this.Controls.Add(label5);

            label6.Text = "Š.okna";
            label6.Location = new Point(300, 220);
            this.Controls.Add(label6);

            label7.Text = "V-okna";
            label7.Location = new Point(300, 260);
            this.Controls.Add(label7);

            label8.Text = "V-textu";
            label8.Location = new Point(300, 300);
            this.Controls.Add(label8);

            this.Controls.Add(label3);
            this.Controls.Add(label4);
            this.Controls.Add(label5);
            this.Controls.Add(label6);
            this.Controls.Add(label7);
            this.Controls.Add(label8);



            neco2 = tlacitko;
            textBox = new TextBox();
            textBox.Name = "textBox";
            textBox.Location = new Point(20, 20);
            this.Controls.Add(textBox);

            fontComboBox = new ComboBox();
            fontComboBox.Name = "fontComboBox";
            fontComboBox.Location = new Point(20, 60);
            // Add font options to the ComboBox
            fontComboBox.Items.AddRange(new string[] { "Arial", "Times New Roman", "Verdana" });
            fontComboBox.Text = "Arial";
            this.Controls.Add(fontComboBox);

            colorInFrontComboBox = new ComboBox();
            colorInFrontComboBox.Name = "colorInFrontComboBox";
            colorInFrontComboBox.Location = new Point(20, 100);
            // Add color options to the ComboBox
            colorInFrontComboBox.Items.AddRange(new string[] {"Red", "Blue", "White", "Black" });
            colorInFrontComboBox.Text = "Red";
            this.Controls.Add(colorInFrontComboBox);

            colorBackgroundComboBox = new ComboBox();
            colorBackgroundComboBox.Name = "colorBackgroundComboBox";
            colorBackgroundComboBox.Location = new Point(20, 140);
            // Add color options to the ComboBox
            colorBackgroundComboBox.Items.AddRange(new string[] { "Red", "Blue", "White", "Black" });
            colorBackgroundComboBox.Text = "Red";
            this.Controls.Add(colorBackgroundComboBox);

            textAlignComboBox = new ComboBox();
            textAlignComboBox.Name = "textAlignComboBox";
            textAlignComboBox.Location = new Point(20, 180);
            // Add text alignment options to the ComboBox
            textAlignComboBox.Items.AddRange(new string[] { "Left", "Center", "Right" });
            textAlignComboBox.Text = "Left";
            this.Controls.Add(textAlignComboBox);

            widthNumericUpDown = new NumericUpDown();
            widthNumericUpDown.Name = "widthNumericUpDown";
            widthNumericUpDown.Location = new Point(20, 220);
            widthNumericUpDown.Minimum = 1;
            widthNumericUpDown.Maximum = 800;
            this.Controls.Add(widthNumericUpDown);

            heightNumericUpDown = new NumericUpDown();
            heightNumericUpDown.Name = "heightNumericUpDown";
            heightNumericUpDown.Location = new Point(20, 260);
            heightNumericUpDown.Minimum = 1;
            heightNumericUpDown.Maximum = 800;
            this.Controls.Add(heightNumericUpDown);

            sizeoftext = new NumericUpDown();
            sizeoftext.Name = "size of text";
            sizeoftext.Location = new Point(20, 300);
            sizeoftext.Minimum = 1;
            sizeoftext.Maximum = 40;
            this.Controls.Add(sizeoftext);

            Button saveButton = new Button();
            saveButton.Text = "Save Values";
            saveButton.Location = new Point(20, 340);
            saveButton.Click += SaveButton_Click;
            this.Controls.Add(saveButton);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!(textBox.Text == string.Empty))
            {
                try
                {
                    // Retrieve and save the values
                    string text = textBox.Text;
                    string font = fontComboBox.SelectedItem.ToString();
                    string colorInFront = colorInFrontComboBox.SelectedItem.ToString();
                    string colorBackground = colorBackgroundComboBox.SelectedItem.ToString();
                    string textAlign = textAlignComboBox.SelectedItem.ToString();
                    int widthOfButton = (int)widthNumericUpDown.Value;
                    int heightOfButton = (int)heightNumericUpDown.Value;
                    int sizeoftext2 = (int)sizeoftext.Value;
                    this.Close();

                    neco2.Size = new Size(widthOfButton, heightOfButton);
                    neco2.Text = text;
                    neco2.Font = new Font(font, sizeoftext2, FontStyle.Regular);

                    if (textAlign == "Left")
                    {
                        neco2.TextAlign = ContentAlignment.MiddleLeft;
                    }
                    else if (textAlign == "Right")
                    {
                        neco2.TextAlign = ContentAlignment.MiddleRight;
                    }
                    else if (textAlign == "Center")
                    {
                        neco2.TextAlign = ContentAlignment.MiddleCenter;
                    }

                    if (colorInFront == "Red")
                    {
                        neco2.ForeColor = Color.Red;
                    }
                    else if (colorInFront == "Blue")
                    {
                        neco2.ForeColor = Color.Blue;
                    }
                    else if (colorBackground == "White")
                    {
                        neco2.ForeColor = Color.White;
                    }
                    else if (colorBackground == "Black")
                    {
                        neco2.ForeColor = Color.Black;
                    }

                    if (colorBackground == "Red")
                    {
                        neco2.BackColor = Color.Red;
                    }
                    else if (colorBackground == "Blue")
                    {
                        neco2.BackColor = Color.Blue;
                    }
                    else if (colorBackground == "White")
                    {
                        neco2.BackColor = Color.White;
                    }
                    else if (colorBackground == "Black")
                    {
                        neco2.BackColor = Color.Black;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }


}