namespace GeometryCalculator.Views
{
    partial class MockView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label sourceProjectionLabel;
            System.Windows.Forms.Label targetProjectionLabel;
            System.Windows.Forms.Label xSourceCoordinatesLabel;
            System.Windows.Forms.Label xTargetCoordinatesLabel;
            System.Windows.Forms.Label ySourceCoordinatesLabel;
            System.Windows.Forms.Label yTargetCoordinatesLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CalcXYButton = new System.Windows.Forms.Button();
            this.sourceProjectionComboBox = new System.Windows.Forms.ComboBox();
            this.xYTransformViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.targetProjectionComboBox = new System.Windows.Forms.ComboBox();
            this.xSourceCoordinatesTextBox = new System.Windows.Forms.TextBox();
            this.xTargetCoordinatesTextBox = new System.Windows.Forms.TextBox();
            this.ySourceCoordinatesTextBox = new System.Windows.Forms.TextBox();
            this.yTargetCoordinatesTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            sourceProjectionLabel = new System.Windows.Forms.Label();
            targetProjectionLabel = new System.Windows.Forms.Label();
            xSourceCoordinatesLabel = new System.Windows.Forms.Label();
            xTargetCoordinatesLabel = new System.Windows.Forms.Label();
            ySourceCoordinatesLabel = new System.Windows.Forms.Label();
            yTargetCoordinatesLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xYTransformViewModelBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceProjectionLabel
            // 
            sourceProjectionLabel.AutoSize = true;
            sourceProjectionLabel.Location = new System.Drawing.Point(255, 48);
            sourceProjectionLabel.Name = "sourceProjectionLabel";
            sourceProjectionLabel.Size = new System.Drawing.Size(80, 13);
            sourceProjectionLabel.TabIndex = 4;
            sourceProjectionLabel.Text = "Quellprojektion:";
            // 
            // targetProjectionLabel
            // 
            targetProjectionLabel.AutoSize = true;
            targetProjectionLabel.Location = new System.Drawing.Point(255, 75);
            targetProjectionLabel.Name = "targetProjectionLabel";
            targetProjectionLabel.Size = new System.Drawing.Size(73, 13);
            targetProjectionLabel.TabIndex = 6;
            targetProjectionLabel.Text = "Zielprojektion:";
            // 
            // xSourceCoordinatesLabel
            // 
            xSourceCoordinatesLabel.AutoSize = true;
            xSourceCoordinatesLabel.Location = new System.Drawing.Point(17, 49);
            xSourceCoordinatesLabel.Name = "xSourceCoordinatesLabel";
            xSourceCoordinatesLabel.Size = new System.Drawing.Size(50, 13);
            xSourceCoordinatesLabel.TabIndex = 0;
            xSourceCoordinatesLabel.Text = "Quelle-X:";
            // 
            // xTargetCoordinatesLabel
            // 
            xTargetCoordinatesLabel.AutoSize = true;
            xTargetCoordinatesLabel.Location = new System.Drawing.Point(486, 48);
            xTargetCoordinatesLabel.Name = "xTargetCoordinatesLabel";
            xTargetCoordinatesLabel.Size = new System.Drawing.Size(37, 13);
            xTargetCoordinatesLabel.TabIndex = 8;
            xTargetCoordinatesLabel.Text = "Ziel-X:";
            // 
            // ySourceCoordinatesLabel
            // 
            ySourceCoordinatesLabel.AutoSize = true;
            ySourceCoordinatesLabel.Location = new System.Drawing.Point(17, 75);
            ySourceCoordinatesLabel.Name = "ySourceCoordinatesLabel";
            ySourceCoordinatesLabel.Size = new System.Drawing.Size(50, 13);
            ySourceCoordinatesLabel.TabIndex = 2;
            ySourceCoordinatesLabel.Text = "Quelle-Y:";
            // 
            // yTargetCoordinatesLabel
            // 
            yTargetCoordinatesLabel.AutoSize = true;
            yTargetCoordinatesLabel.Location = new System.Drawing.Point(486, 75);
            yTargetCoordinatesLabel.Name = "yTargetCoordinatesLabel";
            yTargetCoordinatesLabel.Size = new System.Drawing.Size(37, 13);
            yTargetCoordinatesLabel.TabIndex = 10;
            yTargetCoordinatesLabel.Text = "Ziel-Y:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CalcXYButton);
            this.groupBox1.Controls.Add(sourceProjectionLabel);
            this.groupBox1.Controls.Add(this.sourceProjectionComboBox);
            this.groupBox1.Controls.Add(targetProjectionLabel);
            this.groupBox1.Controls.Add(this.targetProjectionComboBox);
            this.groupBox1.Controls.Add(xSourceCoordinatesLabel);
            this.groupBox1.Controls.Add(this.xSourceCoordinatesTextBox);
            this.groupBox1.Controls.Add(xTargetCoordinatesLabel);
            this.groupBox1.Controls.Add(this.xTargetCoordinatesTextBox);
            this.groupBox1.Controls.Add(ySourceCoordinatesLabel);
            this.groupBox1.Controls.Add(this.ySourceCoordinatesTextBox);
            this.groupBox1.Controls.Add(yTargetCoordinatesLabel);
            this.groupBox1.Controls.Add(this.yTargetCoordinatesTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "XY";
            // 
            // CalcXYButton
            // 
            this.CalcXYButton.Location = new System.Drawing.Point(618, 119);
            this.CalcXYButton.Name = "CalcXYButton";
            this.CalcXYButton.Size = new System.Drawing.Size(75, 23);
            this.CalcXYButton.TabIndex = 12;
            this.CalcXYButton.Text = "Berechnen";
            this.CalcXYButton.UseVisualStyleBackColor = true;
            this.CalcXYButton.Click += new System.EventHandler(this.CalcXYButton_Click);
            // 
            // sourceProjectionComboBox
            // 
            this.sourceProjectionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xYTransformViewModelBindingSource, "SourceProjection", true));
            this.sourceProjectionComboBox.FormattingEnabled = true;
            this.sourceProjectionComboBox.Location = new System.Drawing.Point(341, 45);
            this.sourceProjectionComboBox.Name = "sourceProjectionComboBox";
            this.sourceProjectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.sourceProjectionComboBox.TabIndex = 5;
            // 
            // xYTransformViewModelBindingSource
            // 
            this.xYTransformViewModelBindingSource.DataSource = typeof(GeometryCalculator.ViewModels.XYTransformViewModel);
            // 
            // targetProjectionComboBox
            // 
            this.targetProjectionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xYTransformViewModelBindingSource, "TargetProjection", true));
            this.targetProjectionComboBox.FormattingEnabled = true;
            this.targetProjectionComboBox.Location = new System.Drawing.Point(341, 72);
            this.targetProjectionComboBox.Name = "targetProjectionComboBox";
            this.targetProjectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.targetProjectionComboBox.TabIndex = 7;
            // 
            // xSourceCoordinatesTextBox
            // 
            this.xSourceCoordinatesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xYTransformViewModelBindingSource, "XSourceCoordinates", true));
            this.xSourceCoordinatesTextBox.Location = new System.Drawing.Point(103, 46);
            this.xSourceCoordinatesTextBox.Name = "xSourceCoordinatesTextBox";
            this.xSourceCoordinatesTextBox.Size = new System.Drawing.Size(121, 20);
            this.xSourceCoordinatesTextBox.TabIndex = 1;
            // 
            // xTargetCoordinatesTextBox
            // 
            this.xTargetCoordinatesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xYTransformViewModelBindingSource, "XTargetCoordinates", true));
            this.xTargetCoordinatesTextBox.Location = new System.Drawing.Point(572, 45);
            this.xTargetCoordinatesTextBox.Name = "xTargetCoordinatesTextBox";
            this.xTargetCoordinatesTextBox.Size = new System.Drawing.Size(121, 20);
            this.xTargetCoordinatesTextBox.TabIndex = 9;
            // 
            // ySourceCoordinatesTextBox
            // 
            this.ySourceCoordinatesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xYTransformViewModelBindingSource, "YSourceCoordinates", true));
            this.ySourceCoordinatesTextBox.Location = new System.Drawing.Point(103, 72);
            this.ySourceCoordinatesTextBox.Name = "ySourceCoordinatesTextBox";
            this.ySourceCoordinatesTextBox.Size = new System.Drawing.Size(121, 20);
            this.ySourceCoordinatesTextBox.TabIndex = 3;
            // 
            // yTargetCoordinatesTextBox
            // 
            this.yTargetCoordinatesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xYTransformViewModelBindingSource, "YTargetCoordinates", true));
            this.yTargetCoordinatesTextBox.Location = new System.Drawing.Point(572, 72);
            this.yTargetCoordinatesTextBox.Name = "yTargetCoordinatesTextBox";
            this.yTargetCoordinatesTextBox.Size = new System.Drawing.Size(121, 20);
            this.yTargetCoordinatesTextBox.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(label6);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(label5);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 184);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "WKT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(631, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Berechnen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(268, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 13);
            label1.TabIndex = 17;
            label1.Text = "Quellprojektion:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xYTransformViewModelBindingSource, "SourceProjection", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(354, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(268, 71);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(73, 13);
            label2.TabIndex = 19;
            label2.Text = "Zielprojektion:";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xYTransformViewModelBindingSource, "TargetProjection", true));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(354, 68);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(30, 45);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(50, 13);
            label3.TabIndex = 13;
            label3.Text = "Quelle-X:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xYTransformViewModelBindingSource, "XSourceCoordinates", true));
            this.textBox1.Location = new System.Drawing.Point(116, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(499, 44);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(37, 13);
            label4.TabIndex = 21;
            label4.Text = "Ziel-X:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xYTransformViewModelBindingSource, "XTargetCoordinates", true));
            this.textBox2.Location = new System.Drawing.Point(585, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(30, 71);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(50, 13);
            label5.TabIndex = 15;
            label5.Text = "Quelle-Y:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xYTransformViewModelBindingSource, "YSourceCoordinates", true));
            this.textBox3.Location = new System.Drawing.Point(116, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(499, 71);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(37, 13);
            label6.TabIndex = 23;
            label6.Text = "Ziel-Y:";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xYTransformViewModelBindingSource, "YTargetCoordinates", true));
            this.textBox4.Location = new System.Drawing.Point(585, 68);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 24;
            // 
            // MockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MockView";
            this.Text = "MockView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xYTransformViewModelBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox sourceProjectionComboBox;
        private System.Windows.Forms.BindingSource xYTransformViewModelBindingSource;
        private System.Windows.Forms.ComboBox targetProjectionComboBox;
        private System.Windows.Forms.TextBox xSourceCoordinatesTextBox;
        private System.Windows.Forms.TextBox xTargetCoordinatesTextBox;
        private System.Windows.Forms.TextBox ySourceCoordinatesTextBox;
        private System.Windows.Forms.TextBox yTargetCoordinatesTextBox;
        private System.Windows.Forms.Button CalcXYButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}