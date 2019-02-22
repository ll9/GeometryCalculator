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
            System.Windows.Forms.Label sourceProjectionLabel1;
            System.Windows.Forms.Label targetProjectionLabel1;
            System.Windows.Forms.Label wktSourceLabel;
            System.Windows.Forms.Label wktTargetLabel;
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
            this.sourceProjectionComboBox1 = new System.Windows.Forms.ComboBox();
            this.wktTransformViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.targetProjectionComboBox1 = new System.Windows.Forms.ComboBox();
            this.wktSourceTextBox = new System.Windows.Forms.TextBox();
            this.wktTargetTextBox = new System.Windows.Forms.TextBox();
            this.CalcWktButton = new System.Windows.Forms.Button();
            sourceProjectionLabel = new System.Windows.Forms.Label();
            targetProjectionLabel = new System.Windows.Forms.Label();
            xSourceCoordinatesLabel = new System.Windows.Forms.Label();
            xTargetCoordinatesLabel = new System.Windows.Forms.Label();
            ySourceCoordinatesLabel = new System.Windows.Forms.Label();
            yTargetCoordinatesLabel = new System.Windows.Forms.Label();
            sourceProjectionLabel1 = new System.Windows.Forms.Label();
            targetProjectionLabel1 = new System.Windows.Forms.Label();
            wktSourceLabel = new System.Windows.Forms.Label();
            wktTargetLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xYTransformViewModelBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wktTransformViewModelBindingSource)).BeginInit();
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
            // sourceProjectionLabel1
            // 
            sourceProjectionLabel1.AutoSize = true;
            sourceProjectionLabel1.Location = new System.Drawing.Point(255, 25);
            sourceProjectionLabel1.Name = "sourceProjectionLabel1";
            sourceProjectionLabel1.Size = new System.Drawing.Size(80, 13);
            sourceProjectionLabel1.TabIndex = 25;
            sourceProjectionLabel1.Text = "Quellprojektion:";
            // 
            // targetProjectionLabel1
            // 
            targetProjectionLabel1.AutoSize = true;
            targetProjectionLabel1.Location = new System.Drawing.Point(255, 52);
            targetProjectionLabel1.Name = "targetProjectionLabel1";
            targetProjectionLabel1.Size = new System.Drawing.Size(73, 13);
            targetProjectionLabel1.TabIndex = 27;
            targetProjectionLabel1.Text = "Zielprojektion:";
            // 
            // wktSourceLabel
            // 
            wktSourceLabel.AutoSize = true;
            wktSourceLabel.Location = new System.Drawing.Point(30, 28);
            wktSourceLabel.Name = "wktSourceLabel";
            wktSourceLabel.Size = new System.Drawing.Size(63, 13);
            wktSourceLabel.TabIndex = 29;
            wktSourceLabel.Text = "Quelle-Wkt:";
            // 
            // wktTargetLabel
            // 
            wktTargetLabel.AutoSize = true;
            wktTargetLabel.Location = new System.Drawing.Point(486, 22);
            wktTargetLabel.Name = "wktTargetLabel";
            wktTargetLabel.Size = new System.Drawing.Size(50, 13);
            wktTargetLabel.TabIndex = 31;
            wktTargetLabel.Text = "Ziel-Wkt:";
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
            this.groupBox2.Controls.Add(sourceProjectionLabel1);
            this.groupBox2.Controls.Add(this.sourceProjectionComboBox1);
            this.groupBox2.Controls.Add(targetProjectionLabel1);
            this.groupBox2.Controls.Add(this.targetProjectionComboBox1);
            this.groupBox2.Controls.Add(wktSourceLabel);
            this.groupBox2.Controls.Add(this.wktSourceTextBox);
            this.groupBox2.Controls.Add(wktTargetLabel);
            this.groupBox2.Controls.Add(this.wktTargetTextBox);
            this.groupBox2.Controls.Add(this.CalcWktButton);
            this.groupBox2.Location = new System.Drawing.Point(13, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 184);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "WKT";
            // 
            // sourceProjectionComboBox1
            // 
            this.sourceProjectionComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wktTransformViewModelBindingSource, "SourceProjection", true));
            this.sourceProjectionComboBox1.FormattingEnabled = true;
            this.sourceProjectionComboBox1.Location = new System.Drawing.Point(341, 22);
            this.sourceProjectionComboBox1.Name = "sourceProjectionComboBox1";
            this.sourceProjectionComboBox1.Size = new System.Drawing.Size(121, 21);
            this.sourceProjectionComboBox1.TabIndex = 26;
            // 
            // wktTransformViewModelBindingSource
            // 
            this.wktTransformViewModelBindingSource.DataSource = typeof(GeometryCalculator.ViewModels.WktTransformViewModel);
            // 
            // targetProjectionComboBox1
            // 
            this.targetProjectionComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wktTransformViewModelBindingSource, "TargetProjection", true));
            this.targetProjectionComboBox1.FormattingEnabled = true;
            this.targetProjectionComboBox1.Location = new System.Drawing.Point(341, 49);
            this.targetProjectionComboBox1.Name = "targetProjectionComboBox1";
            this.targetProjectionComboBox1.Size = new System.Drawing.Size(121, 21);
            this.targetProjectionComboBox1.TabIndex = 28;
            // 
            // wktSourceTextBox
            // 
            this.wktSourceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wktTransformViewModelBindingSource, "WktSource", true));
            this.wktSourceTextBox.Location = new System.Drawing.Point(116, 25);
            this.wktSourceTextBox.Name = "wktSourceTextBox";
            this.wktSourceTextBox.Size = new System.Drawing.Size(121, 20);
            this.wktSourceTextBox.TabIndex = 30;
            // 
            // wktTargetTextBox
            // 
            this.wktTargetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wktTransformViewModelBindingSource, "WktTarget", true));
            this.wktTargetTextBox.Location = new System.Drawing.Point(572, 19);
            this.wktTargetTextBox.Name = "wktTargetTextBox";
            this.wktTargetTextBox.Size = new System.Drawing.Size(121, 20);
            this.wktTargetTextBox.TabIndex = 32;
            // 
            // CalcWktButton
            // 
            this.CalcWktButton.Location = new System.Drawing.Point(631, 115);
            this.CalcWktButton.Name = "CalcWktButton";
            this.CalcWktButton.Size = new System.Drawing.Size(75, 23);
            this.CalcWktButton.TabIndex = 25;
            this.CalcWktButton.Text = "Berechnen";
            this.CalcWktButton.UseVisualStyleBackColor = true;
            this.CalcWktButton.Click += new System.EventHandler(this.CalcWktButton_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.wktTransformViewModelBindingSource)).EndInit();
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
        private System.Windows.Forms.Button CalcWktButton;
        private System.Windows.Forms.BindingSource wktTransformViewModelBindingSource;
        private System.Windows.Forms.ComboBox sourceProjectionComboBox1;
        private System.Windows.Forms.ComboBox targetProjectionComboBox1;
        private System.Windows.Forms.TextBox wktSourceTextBox;
        private System.Windows.Forms.TextBox wktTargetTextBox;
    }
}