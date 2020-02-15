namespace bnk
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.index = new System.Windows.Forms.TabPage();
            this.collectData = new System.Windows.Forms.TabPage();
            this.dataObject = new System.Windows.Forms.TabPage();
            this.invertory = new System.Windows.Forms.TabPage();
            this.help = new System.Windows.Forms.TabPage();
            this.setting = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Name = "panel1";
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.index);
            this.tabControl1.Controls.Add(this.collectData);
            this.tabControl1.Controls.Add(this.dataObject);
            this.tabControl1.Controls.Add(this.invertory);
            this.tabControl1.Controls.Add(this.help);
            this.tabControl1.Controls.Add(this.setting);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // index
            // 
            resources.ApplyResources(this.index, "index");
            this.index.BackColor = System.Drawing.SystemColors.Control;
            this.index.Name = "index";
            // 
            // collectData
            // 
            resources.ApplyResources(this.collectData, "collectData");
            this.collectData.BackColor = System.Drawing.SystemColors.Control;
            this.collectData.Name = "collectData";
            // 
            // dataObject
            // 
            resources.ApplyResources(this.dataObject, "dataObject");
            this.dataObject.BackColor = System.Drawing.SystemColors.Control;
            this.dataObject.Name = "dataObject";
            // 
            // invertory
            // 
            resources.ApplyResources(this.invertory, "invertory");
            this.invertory.BackColor = System.Drawing.SystemColors.Control;
            this.invertory.Name = "invertory";
            // 
            // help
            // 
            resources.ApplyResources(this.help, "help");
            this.help.BackColor = System.Drawing.SystemColors.Control;
            this.help.Name = "help";
            // 
            // setting
            // 
            resources.ApplyResources(this.setting, "setting");
            this.setting.BackColor = System.Drawing.SystemColors.Control;
            this.setting.Name = "setting";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Name = "panel2";
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Name = "button6";
            this.button6.UseMnemonic = false;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Name = "button4";
            this.button4.UseMnemonic = false;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Name = "button5";
            this.button5.UseMnemonic = false;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.label1);
            this.panel3.Name = "panel3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Name = "button3";
            this.button3.UseMnemonic = false;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage index;
        private System.Windows.Forms.TabPage collectData;
        private System.Windows.Forms.TabPage dataObject;
        private System.Windows.Forms.TabPage invertory;
        private System.Windows.Forms.TabPage help;
        private System.Windows.Forms.TabPage setting;
    }
}

