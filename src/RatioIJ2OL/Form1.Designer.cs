namespace RatioIJ2OL;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnSelectCsv = new Button();
        dataGridView1 = new DataGridView();
        dataGridView2 = new DataGridView();
        label1 = new Label();
        nudFramesPerIteration = new NumericUpDown();
        label2 = new Label();
        nudSelectedRoi = new NumericUpDown();
        formsPlot1 = new ScottPlot.WinForms.FormsPlot();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudFramesPerIteration).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudSelectedRoi).BeginInit();
        SuspendLayout();
        // 
        // btnSelectCsv
        // 
        btnSelectCsv.Location = new Point(12, 18);
        btnSelectCsv.Name = "btnSelectCsv";
        btnSelectCsv.Size = new Size(135, 37);
        btnSelectCsv.TabIndex = 0;
        btnSelectCsv.Text = "Select CSV";
        btnSelectCsv.UseVisualStyleBackColor = true;
        // 
        // dataGridView1
        // 
        dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(12, 67);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 62;
        dataGridView1.Size = new Size(552, 834);
        dataGridView1.TabIndex = 1;
        // 
        // dataGridView2
        // 
        dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView2.Location = new Point(581, 67);
        dataGridView2.Name = "dataGridView2";
        dataGridView2.RowHeadersWidth = 62;
        dataGridView2.Size = new Size(552, 834);
        dataGridView2.TabIndex = 2;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(581, 24);
        label1.Name = "label1";
        label1.Size = new Size(174, 25);
        label1.TabIndex = 3;
        label1.Text = "Frames per iteration:";
        // 
        // nudFramesPerIteration
        // 
        nudFramesPerIteration.Location = new Point(761, 22);
        nudFramesPerIteration.Name = "nudFramesPerIteration";
        nudFramesPerIteration.Size = new Size(77, 31);
        nudFramesPerIteration.TabIndex = 4;
        nudFramesPerIteration.Value = new decimal(new int[] { 100, 0, 0, 0 });
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(884, 24);
        label2.Name = "label2";
        label2.Size = new Size(95, 25);
        label2.TabIndex = 5;
        label2.Text = "Show ROI:";
        // 
        // nudSelectedRoi
        // 
        nudSelectedRoi.Location = new Point(976, 22);
        nudSelectedRoi.Name = "nudSelectedRoi";
        nudSelectedRoi.Size = new Size(77, 31);
        nudSelectedRoi.TabIndex = 6;
        nudSelectedRoi.Value = new decimal(new int[] { 50, 0, 0, 0 });
        // 
        // formsPlot1
        // 
        formsPlot1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        formsPlot1.DisplayScale = 1.5F;
        formsPlot1.Location = new Point(1140, 68);
        formsPlot1.Name = "formsPlot1";
        formsPlot1.Size = new Size(1002, 834);
        formsPlot1.TabIndex = 7;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(2154, 913);
        Controls.Add(formsPlot1);
        Controls.Add(nudSelectedRoi);
        Controls.Add(label2);
        Controls.Add(nudFramesPerIteration);
        Controls.Add(label1);
        Controls.Add(dataGridView2);
        Controls.Add(dataGridView1);
        Controls.Add(btnSelectCsv);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = " ";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudFramesPerIteration).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudSelectedRoi).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnSelectCsv;
    private DataGridView dataGridView1;
    private DataGridView dataGridView2;
    private Label label1;
    private NumericUpDown nudFramesPerIteration;
    private Label label2;
    private NumericUpDown nudSelectedRoi;
    private ScottPlot.WinForms.FormsPlot formsPlot1;
}
