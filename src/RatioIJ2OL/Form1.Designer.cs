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
        nudSweeps = new NumericUpDown();
        label3 = new Label();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudFramesPerIteration).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudSelectedRoi).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudSweeps).BeginInit();
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
        // dataGridView1
        // 
        dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(8, 40);
        dataGridView1.Margin = new Padding(2);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 62;
        dataGridView1.Size = new Size(386, 500);
        dataGridView1.TabIndex = 1;
        // 
        // dataGridView2
        // 
        dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView2.Location = new Point(407, 40);
        dataGridView2.Margin = new Padding(2);
        dataGridView2.Name = "dataGridView2";
        dataGridView2.RowHeadersWidth = 62;
        dataGridView2.Size = new Size(386, 500);
        dataGridView2.TabIndex = 2;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(407, 14);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(115, 15);
        label1.TabIndex = 3;
        label1.Text = "Frames per iteration:";
        // 
        // nudFramesPerIteration
        // 
        nudFramesPerIteration.Location = new Point(533, 13);
        nudFramesPerIteration.Margin = new Padding(2);
        nudFramesPerIteration.Name = "nudFramesPerIteration";
        nudFramesPerIteration.Size = new Size(54, 23);
        nudFramesPerIteration.TabIndex = 4;
        nudFramesPerIteration.Value = new decimal(new int[] { 50, 0, 0, 0 });
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(619, 14);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(61, 15);
        label2.TabIndex = 5;
        label2.Text = "Show ROI:";
        // 
        // nudSelectedRoi
        // 
        nudSelectedRoi.Location = new Point(683, 13);
        nudSelectedRoi.Margin = new Padding(2);
        nudSelectedRoi.Name = "nudSelectedRoi";
        nudSelectedRoi.Size = new Size(54, 23);
        nudSelectedRoi.TabIndex = 6;
        nudSelectedRoi.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // formsPlot1
        // 
        formsPlot1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        formsPlot1.DisplayScale = 1.5F;
        formsPlot1.Location = new Point(798, 41);
        formsPlot1.Margin = new Padding(2);
        formsPlot1.Name = "formsPlot1";
        formsPlot1.Size = new Size(701, 500);
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
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1508, 548);
        Controls.Add(label3);
        Controls.Add(nudSweeps);
        Controls.Add(formsPlot1);
        Controls.Add(nudSelectedRoi);
        Controls.Add(label2);
        Controls.Add(nudFramesPerIteration);
        Controls.Add(label1);
        Controls.Add(dataGridView2);
        Controls.Add(dataGridView1);
        Controls.Add(btnSelectCsv);
        Margin = new Padding(2);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = " ";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudFramesPerIteration).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudSelectedRoi).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudSweeps).EndInit();
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
    private NumericUpDown nudSweeps;
    private Label label3;
}
