namespace Prueba
{
    partial class Form1
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
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colprestamoid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinteres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplazo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechainicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto_a_pagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto_pendiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseguro = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xpCollection1
            // 
            this.xpCollection1.ObjectType = typeof(Prueba.prueba.Prestamo);
            this.xpCollection1.Session = this.unitOfWork1;
            // 
            // unitOfWork1
            // 
            this.unitOfWork1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.unitOfWork1.TrackPropertiesModifications = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpCollection1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(737, 342);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Aqua;
            this.gridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.DarkOrange;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colprestamoid,
            this.colmonto,
            this.colinteres,
            this.colplazo,
            this.colfechainicial,
            this.colmonto_a_pagar,
            this.colmonto_pendiente,
            this.colactivo,
            this.colestado,
            this.colseguro});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colprestamoid
            // 
            this.colprestamoid.FieldName = "prestamoid";
            this.colprestamoid.Name = "colprestamoid";
            this.colprestamoid.Visible = true;
            this.colprestamoid.VisibleIndex = 0;
            // 
            // colmonto
            // 
            this.colmonto.FieldName = "monto";
            this.colmonto.Name = "colmonto";
            this.colmonto.Visible = true;
            this.colmonto.VisibleIndex = 1;
            // 
            // colinteres
            // 
            this.colinteres.FieldName = "interes";
            this.colinteres.Name = "colinteres";
            this.colinteres.Visible = true;
            this.colinteres.VisibleIndex = 2;
            // 
            // colplazo
            // 
            this.colplazo.FieldName = "plazo";
            this.colplazo.Name = "colplazo";
            this.colplazo.Visible = true;
            this.colplazo.VisibleIndex = 3;
            // 
            // colfechainicial
            // 
            this.colfechainicial.FieldName = "fechainicial";
            this.colfechainicial.Name = "colfechainicial";
            this.colfechainicial.Visible = true;
            this.colfechainicial.VisibleIndex = 4;
            // 
            // colmonto_a_pagar
            // 
            this.colmonto_a_pagar.FieldName = "monto_a_pagar";
            this.colmonto_a_pagar.Name = "colmonto_a_pagar";
            this.colmonto_a_pagar.Visible = true;
            this.colmonto_a_pagar.VisibleIndex = 5;
            // 
            // colmonto_pendiente
            // 
            this.colmonto_pendiente.FieldName = "monto_pendiente";
            this.colmonto_pendiente.Name = "colmonto_pendiente";
            this.colmonto_pendiente.Visible = true;
            this.colmonto_pendiente.VisibleIndex = 6;
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "esActivo";
            this.colactivo.Name = "colactivo";
            this.colactivo.Visible = true;
            this.colactivo.VisibleIndex = 7;
            // 
            // colestado
            // 
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 8;
            // 
            // colseguro
            // 
            this.colseguro.FieldName = "seguro";
            this.colseguro.Name = "colseguro";
            this.colseguro.Visible = true;
            this.colseguro.VisibleIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 342);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colprestamoid;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto;
        private DevExpress.XtraGrid.Columns.GridColumn colinteres;
        private DevExpress.XtraGrid.Columns.GridColumn colplazo;
        private DevExpress.XtraGrid.Columns.GridColumn colfechainicial;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto_a_pagar;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto_pendiente;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colseguro;
    }
}

