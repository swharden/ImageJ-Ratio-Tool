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
        dataGridView2 = new DataGridView();
        label2 = new Label();
        nudSelectedRoi = new NumericUpDown();
        formsPlot1 = new ScottPlot.WinForms.FormsPlot();
        nudSweeps = new NumericUpDown();
        label3 = new Label();
        nudBaseline1 = new NumericUpDown();
        label1 = new Label();
        nudBaseline2 = new NumericUpDown();
        splitContainer1 = new SplitContainer();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudSelectedRoi).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudSweeps).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudBaseline1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudBaseline2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        SuspendLayout();
        // 
        // btnSelectCsv
        // 
        btnSelectCsv.Location = new Point(8, 11);
        btnSelectCsv.Margin = new Padding(2);
        btnSelectCsv.Name = "btnSelectCsv";
        btnSelectCsv.Size = new Size(94, 22);
        btnSelectCsv.TabIndex = 0;
        btnSelectCsv.Text = "Select CSV";
        btnSelectCsv.UseVisualStyleBackColor = true;
        // 
        // dataGridView2
        // 
        dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView2.Dock = DockStyle.Fill;
        dataGridView2.Location = new Point(0, 0);
        dataGridView2.Margin = new Padding(2);
        dataGridView2.Name = "dataGridView2";
        dataGridView2.RowHeadersWidth = 62;
        dataGridView2.Size = new Size(500, 486);
        dataGridView2.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(270, 14);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(29, 15);
        label2.TabIndex = 5;
        label2.Text = "ROI:";
        // 
        // nudSelectedRoi
        // 
        nudSelectedRoi.Location = new Point(303, 12);
        nudSelectedRoi.Margin = new Padding(2);
        nudSelectedRoi.Name = "nudSelectedRoi";
        nudSelectedRoi.Size = new Size(54, 23);
        nudSelectedRoi.TabIndex = 6;
        nudSelectedRoi.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // formsPlot1
        // 
        formsPlot1.DisplayScale = 1.5F;
        formsPlot1.Dock = DockStyle.Fill;
        formsPlot1.Location = new Point(0, 0);
        formsPlot1.Margin = new Padding(2);
        formsPlot1.Name = "formsPlot1";
        formsPlot1.Size = new Size(736, 486);
        formsPlot1.TabIndex = 7;
        // 
        // nudSweeps
        // 
        nudSweeps.Location = new Point(177, 12);
        nudSweeps.Margin = new Padding(2);
        nudSweeps.Name = "nudSweeps";
        nudSweeps.Size = new Size(54, 23);
        nudSweeps.TabIndex = 8;
        nudSweeps.Value = new decimal(new int[] { 5, 0, 0, 0 });
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(124, 15);
        label3.Margin = new Padding(2, 0, 2, 0);
        label3.Name = "label3";
        label3.Size = new Size(49, 15);
        label3.TabIndex = 9;
        label3.Text = "Sweeps:";
        // 
        // nudBaseline1
        // 
        nudBaseline1.DecimalPlaces = 2;
        nudBaseline1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
        nudBaseline1.Location = new Point(471, 12);
        nudBaseline1.Margin = new Padding(2);
        nudBaseline1.Name = "nudBaseline1";
        nudBaseline1.Size = new Size(54, 23);
        nudBaseline1.TabIndex = 11;
        nudBaseline1.Value = new decimal(new int[] { 25, 0, 0, 131072 });
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(414, 14);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(53, 15);
        label1.TabIndex = 10;
        label1.Text = "Baseline:";
        // 
        // nudBaseline2
        // 
        nudBaseline2.DecimalPlaces = 2;
        nudBaseline2.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
        nudBaseline2.Location = new Point(529, 12);
        nudBaseline2.Margin = new Padding(2);
        nudBaseline2.Name = "nudBaseline2";
        nudBaseline2.Size = new Size(54, 23);
        nudBaseline2.TabIndex = 12;
        nudBaseline2.Value = new decimal(new int[] { 75, 0, 0, 131072 });
        // 
        // splitContainer1
        // 
        splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        splitContainer1.Location = new Point(8, 45);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(dataGridView2);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(formsPlot1);
        splitContainer1.Size = new Size(1240, 486);
        splitContainer1.SplitterDistance = 500;
        splitContainer1.TabIndex = 13;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1260, 543);
        Controls.Add(splitContainer1);
        Controls.Add(nudBaseline2);
        Controls.Add(nudBaseline1);
        Controls.Add(label1);
        Controls.Add(label3);
        Controls.Add(nudSweeps);
        Controls.Add(nudSelectedRoi);
        Controls.Add(label2);
        Controls.Add(btnSelectCsv);
        Margin = new Padding(2);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ImageJ Ratiometric ROI Analysis Tool";
        ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudSelectedRoi).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudSweeps).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudBaseline1).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudBaseline2).EndInit();
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnSelectCsv;
    private DataGridView dataGridView2;
    private Label label2;
    private NumericUpDown nudSelectedRoi;
    private ScottPlot.WinForms.FormsPlot formsPlot1;
    private NumericUpDown nudSweeps;
    private Label label3;
    private NumericUpDown nudBaseline1;
    private Label label1;
    private NumericUpDown nudBaseline2;
    private SplitContainer splitContainer1;
}
