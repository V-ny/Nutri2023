﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim CODIGOLabel As System.Windows.Forms.Label
        Dim NOMELabel As System.Windows.Forms.Label
        Dim SOBRENOMELabel As System.Windows.Forms.Label
        Dim ENDERECOLabel As System.Windows.Forms.Label
        Dim CELULARLabel As System.Windows.Forms.Label
        Dim EMAILLabel As System.Windows.Forms.Label
        Dim SEXOLabel As System.Windows.Forms.Label
        Dim DTNASCIMENTOLabel As System.Windows.Forms.Label
        Dim PESOLabel As System.Windows.Forms.Label
        Dim ALTURALabel As System.Windows.Forms.Label
        Dim IMCLabel As System.Windows.Forms.Label
        Dim CONDICAOLabel As System.Windows.Forms.Label
        Dim FOTOLabel As System.Windows.Forms.Label
        Dim OBSLabel As System.Windows.Forms.Label
        Me.NUTRI2023DataSet = New Nutri2023.NUTRI2023DataSet()
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PACIENTESTableAdapter = New Nutri2023.NUTRI2023DataSetTableAdapters.PACIENTESTableAdapter()
        Me.TableAdapterManager = New Nutri2023.NUTRI2023DataSetTableAdapters.TableAdapterManager()
        Me.PACIENTESBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PACIENTESBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CODIGOTextBox = New System.Windows.Forms.TextBox()
        Me.NOMETextBox = New System.Windows.Forms.TextBox()
        Me.SOBRENOMETextBox = New System.Windows.Forms.TextBox()
        Me.ENDERECOTextBox = New System.Windows.Forms.TextBox()
        Me.CELULARMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EMAILTextBox = New System.Windows.Forms.TextBox()
        Me.SEXOComboBox = New System.Windows.Forms.ComboBox()
        Me.DTNASCIMENTOMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PESOTextBox = New System.Windows.Forms.TextBox()
        Me.ALTURATextBox = New System.Windows.Forms.TextBox()
        Me.IMCTextBox = New System.Windows.Forms.TextBox()
        Me.CONDICAOTextBox = New System.Windows.Forms.TextBox()
        Me.FOTOPictureBox = New System.Windows.Forms.PictureBox()
        Me.OBSTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CODIGOLabel = New System.Windows.Forms.Label()
        NOMELabel = New System.Windows.Forms.Label()
        SOBRENOMELabel = New System.Windows.Forms.Label()
        ENDERECOLabel = New System.Windows.Forms.Label()
        CELULARLabel = New System.Windows.Forms.Label()
        EMAILLabel = New System.Windows.Forms.Label()
        SEXOLabel = New System.Windows.Forms.Label()
        DTNASCIMENTOLabel = New System.Windows.Forms.Label()
        PESOLabel = New System.Windows.Forms.Label()
        ALTURALabel = New System.Windows.Forms.Label()
        IMCLabel = New System.Windows.Forms.Label()
        CONDICAOLabel = New System.Windows.Forms.Label()
        FOTOLabel = New System.Windows.Forms.Label()
        OBSLabel = New System.Windows.Forms.Label()
        CType(Me.NUTRI2023DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTESBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PACIENTESBindingNavigator.SuspendLayout()
        CType(Me.FOTOPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NUTRI2023DataSet
        '
        Me.NUTRI2023DataSet.DataSetName = "NUTRI2023DataSet"
        Me.NUTRI2023DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PACIENTESBindingSource
        '
        Me.PACIENTESBindingSource.DataMember = "PACIENTES"
        Me.PACIENTESBindingSource.DataSource = Me.NUTRI2023DataSet
        '
        'PACIENTESTableAdapter
        '
        Me.PACIENTESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PACIENTESTableAdapter = Me.PACIENTESTableAdapter
        Me.TableAdapterManager.UpdateOrder = Nutri2023.NUTRI2023DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PACIENTESBindingNavigator
        '
        Me.PACIENTESBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PACIENTESBindingNavigator.BindingSource = Me.PACIENTESBindingSource
        Me.PACIENTESBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PACIENTESBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PACIENTESBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PACIENTESBindingNavigatorSaveItem})
        Me.PACIENTESBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PACIENTESBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PACIENTESBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PACIENTESBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PACIENTESBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PACIENTESBindingNavigator.Name = "PACIENTESBindingNavigator"
        Me.PACIENTESBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PACIENTESBindingNavigator.Size = New System.Drawing.Size(503, 25)
        Me.PACIENTESBindingNavigator.TabIndex = 0
        Me.PACIENTESBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição atual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Excluir"
        '
        'PACIENTESBindingNavigatorSaveItem
        '
        Me.PACIENTESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PACIENTESBindingNavigatorSaveItem.Image = CType(resources.GetObject("PACIENTESBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PACIENTESBindingNavigatorSaveItem.Name = "PACIENTESBindingNavigatorSaveItem"
        Me.PACIENTESBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PACIENTESBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'CODIGOLabel
        '
        CODIGOLabel.AutoSize = True
        CODIGOLabel.Location = New System.Drawing.Point(49, 43)
        CODIGOLabel.Name = "CODIGOLabel"
        CODIGOLabel.Size = New System.Drawing.Size(52, 13)
        CODIGOLabel.TabIndex = 1
        CODIGOLabel.Text = "CODIGO:"
        '
        'CODIGOTextBox
        '
        Me.CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "CODIGO", True))
        Me.CODIGOTextBox.Enabled = False
        Me.CODIGOTextBox.Location = New System.Drawing.Point(151, 40)
        Me.CODIGOTextBox.Name = "CODIGOTextBox"
        Me.CODIGOTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CODIGOTextBox.TabIndex = 2
        '
        'NOMELabel
        '
        NOMELabel.AutoSize = True
        NOMELabel.Location = New System.Drawing.Point(49, 69)
        NOMELabel.Name = "NOMELabel"
        NOMELabel.Size = New System.Drawing.Size(42, 13)
        NOMELabel.TabIndex = 3
        NOMELabel.Text = "NOME:"
        '
        'NOMETextBox
        '
        Me.NOMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "NOME", True))
        Me.NOMETextBox.Location = New System.Drawing.Point(151, 66)
        Me.NOMETextBox.Name = "NOMETextBox"
        Me.NOMETextBox.Size = New System.Drawing.Size(121, 20)
        Me.NOMETextBox.TabIndex = 4
        '
        'SOBRENOMELabel
        '
        SOBRENOMELabel.AutoSize = True
        SOBRENOMELabel.Location = New System.Drawing.Point(49, 95)
        SOBRENOMELabel.Name = "SOBRENOMELabel"
        SOBRENOMELabel.Size = New System.Drawing.Size(79, 13)
        SOBRENOMELabel.TabIndex = 5
        SOBRENOMELabel.Text = "SOBRENOME:"
        '
        'SOBRENOMETextBox
        '
        Me.SOBRENOMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "SOBRENOME", True))
        Me.SOBRENOMETextBox.Location = New System.Drawing.Point(151, 92)
        Me.SOBRENOMETextBox.Name = "SOBRENOMETextBox"
        Me.SOBRENOMETextBox.Size = New System.Drawing.Size(121, 20)
        Me.SOBRENOMETextBox.TabIndex = 6
        '
        'ENDERECOLabel
        '
        ENDERECOLabel.AutoSize = True
        ENDERECOLabel.Location = New System.Drawing.Point(49, 121)
        ENDERECOLabel.Name = "ENDERECOLabel"
        ENDERECOLabel.Size = New System.Drawing.Size(70, 13)
        ENDERECOLabel.TabIndex = 7
        ENDERECOLabel.Text = "ENDERECO:"
        '
        'ENDERECOTextBox
        '
        Me.ENDERECOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "ENDERECO", True))
        Me.ENDERECOTextBox.Location = New System.Drawing.Point(151, 118)
        Me.ENDERECOTextBox.Multiline = True
        Me.ENDERECOTextBox.Name = "ENDERECOTextBox"
        Me.ENDERECOTextBox.Size = New System.Drawing.Size(121, 52)
        Me.ENDERECOTextBox.TabIndex = 8
        '
        'CELULARLabel
        '
        CELULARLabel.AutoSize = True
        CELULARLabel.Location = New System.Drawing.Point(49, 179)
        CELULARLabel.Name = "CELULARLabel"
        CELULARLabel.Size = New System.Drawing.Size(59, 13)
        CELULARLabel.TabIndex = 9
        CELULARLabel.Text = "CELULAR:"
        '
        'CELULARMaskedTextBox
        '
        Me.CELULARMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "CELULAR", True))
        Me.CELULARMaskedTextBox.Location = New System.Drawing.Point(151, 176)
        Me.CELULARMaskedTextBox.Mask = "(00) 00000-0000"
        Me.CELULARMaskedTextBox.Name = "CELULARMaskedTextBox"
        Me.CELULARMaskedTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CELULARMaskedTextBox.TabIndex = 10
        '
        'EMAILLabel
        '
        EMAILLabel.AutoSize = True
        EMAILLabel.Location = New System.Drawing.Point(49, 205)
        EMAILLabel.Name = "EMAILLabel"
        EMAILLabel.Size = New System.Drawing.Size(42, 13)
        EMAILLabel.TabIndex = 11
        EMAILLabel.Text = "EMAIL:"
        '
        'EMAILTextBox
        '
        Me.EMAILTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "EMAIL", True))
        Me.EMAILTextBox.Location = New System.Drawing.Point(151, 202)
        Me.EMAILTextBox.Name = "EMAILTextBox"
        Me.EMAILTextBox.Size = New System.Drawing.Size(121, 20)
        Me.EMAILTextBox.TabIndex = 12
        '
        'SEXOLabel
        '
        SEXOLabel.AutoSize = True
        SEXOLabel.Location = New System.Drawing.Point(49, 231)
        SEXOLabel.Name = "SEXOLabel"
        SEXOLabel.Size = New System.Drawing.Size(39, 13)
        SEXOLabel.TabIndex = 13
        SEXOLabel.Text = "SEXO:"
        '
        'SEXOComboBox
        '
        Me.SEXOComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "SEXO", True))
        Me.SEXOComboBox.FormattingEnabled = True
        Me.SEXOComboBox.Items.AddRange(New Object() {"", "Feminino", "Masculino"})
        Me.SEXOComboBox.Location = New System.Drawing.Point(151, 228)
        Me.SEXOComboBox.Name = "SEXOComboBox"
        Me.SEXOComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SEXOComboBox.TabIndex = 14
        '
        'DTNASCIMENTOLabel
        '
        DTNASCIMENTOLabel.AutoSize = True
        DTNASCIMENTOLabel.Location = New System.Drawing.Point(49, 258)
        DTNASCIMENTOLabel.Name = "DTNASCIMENTOLabel"
        DTNASCIMENTOLabel.Size = New System.Drawing.Size(96, 13)
        DTNASCIMENTOLabel.TabIndex = 15
        DTNASCIMENTOLabel.Text = "DTNASCIMENTO:"
        '
        'DTNASCIMENTOMaskedTextBox
        '
        Me.DTNASCIMENTOMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "DTNASCIMENTO", True))
        Me.DTNASCIMENTOMaskedTextBox.Location = New System.Drawing.Point(151, 255)
        Me.DTNASCIMENTOMaskedTextBox.Mask = "00/00/0000"
        Me.DTNASCIMENTOMaskedTextBox.Name = "DTNASCIMENTOMaskedTextBox"
        Me.DTNASCIMENTOMaskedTextBox.Size = New System.Drawing.Size(121, 20)
        Me.DTNASCIMENTOMaskedTextBox.TabIndex = 16
        '
        'PESOLabel
        '
        PESOLabel.AutoSize = True
        PESOLabel.Location = New System.Drawing.Point(49, 284)
        PESOLabel.Name = "PESOLabel"
        PESOLabel.Size = New System.Drawing.Size(39, 13)
        PESOLabel.TabIndex = 17
        PESOLabel.Text = "PESO:"
        '
        'PESOTextBox
        '
        Me.PESOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "PESO", True))
        Me.PESOTextBox.Location = New System.Drawing.Point(151, 281)
        Me.PESOTextBox.Name = "PESOTextBox"
        Me.PESOTextBox.Size = New System.Drawing.Size(121, 20)
        Me.PESOTextBox.TabIndex = 18
        '
        'ALTURALabel
        '
        ALTURALabel.AutoSize = True
        ALTURALabel.Location = New System.Drawing.Point(49, 310)
        ALTURALabel.Name = "ALTURALabel"
        ALTURALabel.Size = New System.Drawing.Size(53, 13)
        ALTURALabel.TabIndex = 19
        ALTURALabel.Text = "ALTURA:"
        '
        'ALTURATextBox
        '
        Me.ALTURATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "ALTURA", True))
        Me.ALTURATextBox.Location = New System.Drawing.Point(151, 307)
        Me.ALTURATextBox.Name = "ALTURATextBox"
        Me.ALTURATextBox.Size = New System.Drawing.Size(121, 20)
        Me.ALTURATextBox.TabIndex = 20
        '
        'IMCLabel
        '
        IMCLabel.AutoSize = True
        IMCLabel.Location = New System.Drawing.Point(49, 336)
        IMCLabel.Name = "IMCLabel"
        IMCLabel.Size = New System.Drawing.Size(29, 13)
        IMCLabel.TabIndex = 21
        IMCLabel.Text = "IMC:"
        '
        'IMCTextBox
        '
        Me.IMCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "IMC", True))
        Me.IMCTextBox.Enabled = False
        Me.IMCTextBox.Location = New System.Drawing.Point(151, 333)
        Me.IMCTextBox.Name = "IMCTextBox"
        Me.IMCTextBox.Size = New System.Drawing.Size(121, 20)
        Me.IMCTextBox.TabIndex = 22
        '
        'CONDICAOLabel
        '
        CONDICAOLabel.AutoSize = True
        CONDICAOLabel.Location = New System.Drawing.Point(49, 362)
        CONDICAOLabel.Name = "CONDICAOLabel"
        CONDICAOLabel.Size = New System.Drawing.Size(66, 13)
        CONDICAOLabel.TabIndex = 23
        CONDICAOLabel.Text = "CONDICAO:"
        '
        'CONDICAOTextBox
        '
        Me.CONDICAOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "CONDICAO", True))
        Me.CONDICAOTextBox.Enabled = False
        Me.CONDICAOTextBox.Location = New System.Drawing.Point(151, 359)
        Me.CONDICAOTextBox.Name = "CONDICAOTextBox"
        Me.CONDICAOTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CONDICAOTextBox.TabIndex = 24
        '
        'FOTOLabel
        '
        FOTOLabel.AutoSize = True
        FOTOLabel.Location = New System.Drawing.Point(335, 43)
        FOTOLabel.Name = "FOTOLabel"
        FOTOLabel.Size = New System.Drawing.Size(39, 13)
        FOTOLabel.TabIndex = 25
        FOTOLabel.Text = "FOTO:"
        '
        'FOTOPictureBox
        '
        Me.FOTOPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.PACIENTESBindingSource, "FOTO", True))
        Me.FOTOPictureBox.Location = New System.Drawing.Point(338, 62)
        Me.FOTOPictureBox.Name = "FOTOPictureBox"
        Me.FOTOPictureBox.Size = New System.Drawing.Size(121, 124)
        Me.FOTOPictureBox.TabIndex = 26
        Me.FOTOPictureBox.TabStop = False
        '
        'OBSLabel
        '
        OBSLabel.AutoSize = True
        OBSLabel.Location = New System.Drawing.Point(49, 393)
        OBSLabel.Name = "OBSLabel"
        OBSLabel.Size = New System.Drawing.Size(32, 13)
        OBSLabel.TabIndex = 27
        OBSLabel.Text = "OBS:"
        '
        'OBSTextBox
        '
        Me.OBSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "OBS", True))
        Me.OBSTextBox.Location = New System.Drawing.Point(151, 390)
        Me.OBSTextBox.Multiline = True
        Me.OBSTextBox.Name = "OBSTextBox"
        Me.OBSTextBox.Size = New System.Drawing.Size(121, 49)
        Me.OBSTextBox.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(338, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Inserir Foto..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 487)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(CODIGOLabel)
        Me.Controls.Add(Me.CODIGOTextBox)
        Me.Controls.Add(NOMELabel)
        Me.Controls.Add(Me.NOMETextBox)
        Me.Controls.Add(SOBRENOMELabel)
        Me.Controls.Add(Me.SOBRENOMETextBox)
        Me.Controls.Add(ENDERECOLabel)
        Me.Controls.Add(Me.ENDERECOTextBox)
        Me.Controls.Add(CELULARLabel)
        Me.Controls.Add(Me.CELULARMaskedTextBox)
        Me.Controls.Add(EMAILLabel)
        Me.Controls.Add(Me.EMAILTextBox)
        Me.Controls.Add(SEXOLabel)
        Me.Controls.Add(Me.SEXOComboBox)
        Me.Controls.Add(DTNASCIMENTOLabel)
        Me.Controls.Add(Me.DTNASCIMENTOMaskedTextBox)
        Me.Controls.Add(PESOLabel)
        Me.Controls.Add(Me.PESOTextBox)
        Me.Controls.Add(ALTURALabel)
        Me.Controls.Add(Me.ALTURATextBox)
        Me.Controls.Add(IMCLabel)
        Me.Controls.Add(Me.IMCTextBox)
        Me.Controls.Add(CONDICAOLabel)
        Me.Controls.Add(Me.CONDICAOTextBox)
        Me.Controls.Add(FOTOLabel)
        Me.Controls.Add(Me.FOTOPictureBox)
        Me.Controls.Add(OBSLabel)
        Me.Controls.Add(Me.OBSTextBox)
        Me.Controls.Add(Me.PACIENTESBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "SGC - Sistema de Gerenciamento Clínico"
        CType(Me.NUTRI2023DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTESBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PACIENTESBindingNavigator.ResumeLayout(False)
        Me.PACIENTESBindingNavigator.PerformLayout()
        CType(Me.FOTOPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NUTRI2023DataSet As NUTRI2023DataSet
    Friend WithEvents PACIENTESBindingSource As BindingSource
    Friend WithEvents PACIENTESTableAdapter As NUTRI2023DataSetTableAdapters.PACIENTESTableAdapter
    Friend WithEvents TableAdapterManager As NUTRI2023DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PACIENTESBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PACIENTESBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CODIGOTextBox As TextBox
    Friend WithEvents NOMETextBox As TextBox
    Friend WithEvents SOBRENOMETextBox As TextBox
    Friend WithEvents ENDERECOTextBox As TextBox
    Friend WithEvents CELULARMaskedTextBox As MaskedTextBox
    Friend WithEvents EMAILTextBox As TextBox
    Friend WithEvents SEXOComboBox As ComboBox
    Friend WithEvents DTNASCIMENTOMaskedTextBox As MaskedTextBox
    Friend WithEvents PESOTextBox As TextBox
    Friend WithEvents ALTURATextBox As TextBox
    Friend WithEvents IMCTextBox As TextBox
    Friend WithEvents CONDICAOTextBox As TextBox
    Friend WithEvents FOTOPictureBox As PictureBox
    Friend WithEvents OBSTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
