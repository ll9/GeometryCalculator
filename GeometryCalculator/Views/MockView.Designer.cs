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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sourceProjectionComboBox = new System.Windows.Forms.ComboBox();
            this.targetProjectionComboBox = new System.Windows.Forms.ComboBox();
            this.xSourceCoordinatesTextBox = new System.Windows.Forms.TextBox();
            this.xTargetCoordinatesTextBox = new System.Windows.Forms.TextBox();
            this.ySourceCoordinatesTextBox = new System.Windows.Forms.TextBox();
            this.yTargetCoordinatesTextBox = new System.Windows.Forms.TextBox();
            this.xYTransformViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            sourceProjectionLabel = new System.Windows.Forms.Label();
            targetProjectionLabel = new System.Windows.Forms.Label();
            xSourceCoordinatesLabel = new System.Windows.Forms.Label();
            xTargetCoordinatesLabel = new System.Windows.Forms.Label();
            ySourceCoordinatesLabel = new System.Windows.Forms.Label();
            yTargetCoordinatesLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xYTransformViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(13, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 184);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
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
            // sourceProjectionComboBox
            // 
            this.sourceProjectionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xYTransformViewModelBindingSource, "SourceProjection", true));
            this.sourceProjectionComboBox.FormattingEnabled = true;
            this.sourceProjectionComboBox.Location = new System.Drawing.Point(341, 45);
            this.sourceProjectionComboBox.Name = "sourceProjectionComboBox";
            this.sourceProjectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.sourceProjectionComboBox.TabIndex = 5;
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
            // targetProjectionComboBox
            // 
            this.targetProjectionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xYTransformViewModelBindingSource, "TargetProjection", true));
            this.targetProjectionComboBox.FormattingEnabled = true;
            this.targetProjectionComboBox.Location = new System.Drawing.Point(341, 72);
            this.targetProjectionComboBox.Name = "targetProjectionComboBox";
            this.targetProjectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.targetProjectionComboBox.TabIndex = 7;
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
            // xSourceCoordinatesTextBox
            // 
            this.xSourceCoordinatesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xYTransformViewModelBindingSource, "XSourceCoordinates", true));
            this.xSourceCoordinatesTextBox.Location = new System.Drawing.Point(103, 46);
            this.xSourceCoordinatesTextBox.Name = "xSourceCoordinatesTextBox";
            this.xSourceCoordinatesTextBox.Size = new System.Drawing.Size(121, 20);
            this.xSourceCoordinatesTextBox.TabIndex = 1;
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
            // xTargetCoordinatesTextBox
            // 
            this.xTargetCoordinatesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xYTransformViewModelBindingSource, "XTargetCoordinates", true));
            this.xTargetCoordinatesTextBox.Location = new System.Drawing.Point(572, 45);
            this.xTargetCoordinatesTextBox.Name = "xTargetCoordinatesTextBox";
            this.xTargetCoordinatesTextBox.Size = new System.Drawing.Size(121, 20);
            this.xTargetCoordinatesTextBox.TabIndex = 9;
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
            // ySourceCoordinatesTextBox
            // 
            this.ySourceCoordinatesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xYTransformViewModelBindingSource, "YSourceCoordinates", true));
            this.ySourceCoordinatesTextBox.Location = new System.Drawing.Point(103, 72);
            this.ySourceCoordinatesTextBox.Name = "ySourceCoordinatesTextBox";
            this.ySourceCoordinatesTextBox.Size = new System.Drawing.Size(121, 20);
            this.ySourceCoordinatesTextBox.TabIndex = 3;
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
            // yTargetCoordinatesTextBox
            // 
            this.yTargetCoordinatesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xYTransformViewModelBindingSource, "YTargetCoordinates", true));
            this.yTargetCoordinatesTextBox.Location = new System.Drawing.Point(572, 72);
            this.yTargetCoordinatesTextBox.Name = "yTargetCoordinatesTextBox";
            this.yTargetCoordinatesTextBox.Size = new System.Drawing.Size(121, 20);
            this.yTargetCoordinatesTextBox.TabIndex = 11;
            // 
            // xYTransformViewModelBindingSource
            // 
            this.xYTransformViewModelBindingSource.DataSource = typeof(GeometryCalculator.ViewModels.XYTransformViewModel);
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
    }
}