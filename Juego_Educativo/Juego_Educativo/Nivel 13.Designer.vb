﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nivel_13
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nivel_13))
        Me.Btn_RegresaMenu = New System.Windows.Forms.Button()
        Me.img3 = New System.Windows.Forms.PictureBox()
        Me.img2 = New System.Windows.Forms.PictureBox()
        Me.img1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblap = New System.Windows.Forms.Label()
        Me.Btn_Calificar = New System.Windows.Forms.Button()
        CType(Me.img3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_RegresaMenu
        '
        Me.Btn_RegresaMenu.BackgroundImage = CType(resources.GetObject("Btn_RegresaMenu.BackgroundImage"), System.Drawing.Image)
        Me.Btn_RegresaMenu.Location = New System.Drawing.Point(94, 533)
        Me.Btn_RegresaMenu.Name = "Btn_RegresaMenu"
        Me.Btn_RegresaMenu.Size = New System.Drawing.Size(130, 37)
        Me.Btn_RegresaMenu.TabIndex = 9
        Me.Btn_RegresaMenu.UseVisualStyleBackColor = True
        '
        'img3
        '
        Me.img3.Image = Global.Juego_Educativo.My.Resources.Resources.images__4_
        Me.img3.Location = New System.Drawing.Point(393, 176)
        Me.img3.Name = "img3"
        Me.img3.Size = New System.Drawing.Size(140, 95)
        Me.img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img3.TabIndex = 27
        Me.img3.TabStop = False
        '
        'img2
        '
        Me.img2.Image = Global.Juego_Educativo.My.Resources.Resources.images__3_
        Me.img2.Location = New System.Drawing.Point(226, 176)
        Me.img2.Name = "img2"
        Me.img2.Size = New System.Drawing.Size(126, 95)
        Me.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img2.TabIndex = 26
        Me.img2.TabStop = False
        '
        'img1
        '
        Me.img1.Image = Global.Juego_Educativo.My.Resources.Resources.descarga
        Me.img1.Location = New System.Drawing.Point(46, 176)
        Me.img1.Name = "img1"
        Me.img1.Size = New System.Drawing.Size(126, 95)
        Me.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img1.TabIndex = 25
        Me.img1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(58, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(473, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "the landscape has two palm trees and two boats"
        '
        'lblap
        '
        Me.lblap.AutoSize = True
        Me.lblap.BackColor = System.Drawing.Color.Transparent
        Me.lblap.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblap.ForeColor = System.Drawing.Color.Black
        Me.lblap.Location = New System.Drawing.Point(149, 32)
        Me.lblap.Name = "lblap"
        Me.lblap.Size = New System.Drawing.Size(280, 25)
        Me.lblap.TabIndex = 23
        Me.lblap.Text = "selecciona lo que se te pide"
        '
        'Btn_Calificar
        '
        Me.Btn_Calificar.Location = New System.Drawing.Point(478, 547)
        Me.Btn_Calificar.Name = "Btn_Calificar"
        Me.Btn_Calificar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Calificar.TabIndex = 28
        Me.Btn_Calificar.Text = "Calificar"
        Me.Btn_Calificar.UseVisualStyleBackColor = True
        '
        'Nivel_13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(812, 582)
        Me.Controls.Add(Me.Btn_Calificar)
        Me.Controls.Add(Me.img3)
        Me.Controls.Add(Me.img2)
        Me.Controls.Add(Me.img1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblap)
        Me.Controls.Add(Me.Btn_RegresaMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Nivel_13"
        Me.Text = "Nivel_13"
        CType(Me.img3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_RegresaMenu As System.Windows.Forms.Button
    Friend WithEvents img3 As System.Windows.Forms.PictureBox
    Friend WithEvents img2 As System.Windows.Forms.PictureBox
    Friend WithEvents img1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblap As System.Windows.Forms.Label
    Friend WithEvents Btn_Calificar As System.Windows.Forms.Button
End Class
