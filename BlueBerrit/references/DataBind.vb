Imports BlueBerrit.ServiceClasses

Namespace ServiceClasses
    Public Class DataBind
        Public objService As DataService
        Dim objError As DataError
        Public Sub New()
        End Sub

        Public Sub BindDataGrid(ByVal strTableName As String, ByVal ctlDataGrid As DataGrid)

            Try
                objService = New DataService
                objService.FillDataSet(strTableName)
                ctlDataGrid.DataSource = objService.ObjDT
                ctlDataGrid.DataBind()
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally
                objService.CloseConnection()
            End Try

        End Sub

        Public Sub BindDataGrid(ByVal strTableName As String, ByVal strCondition As String, ByVal ctlDataGrid As DataGrid)

            Try
                objService = New DataService

                objService.FillDataSet(strTableName, strCondition)
                ctlDataGrid.DataSource = objService.ObjDT
                ctlDataGrid.DataBind()
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally
                objService.CloseConnection()
            End Try

        End Sub

        Public Sub BindList(ByVal strTableName As String, ByVal strCondition As String, ByVal ctlDataList As DataList)

            Try
                objService = New DataService
                If strCondition = "Nothing" Then
                    objService.FillDataSet(strTableName)
                Else
                    objService.FillDataSet(strTableName, strCondition)
                End If

                ctlDataList.DataSource = objService.ObjDT
                ctlDataList.DataBind()
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally
                objService.CloseConnection()
            End Try

        End Sub
        'Public Sub BindListSelect(ByVal strTableName As String, ByVal strFields As String, ByVal strCondition As String, ByVal ctlDataList As DataList)

        '    Try
        '        objService = New DataService
        '        If strCondition = "Nothing" Then
        '            objService.FillDataSet(strTableName)
        '        Else
        '            objService.FillDataSetSelect(strTableName, strCondition, strFields)
        '        End If

        '        ctlDataList.DataSource = objService.objDT
        '        ctlDataList.DataBind()
        '    Catch ex As Exception
        '        objError = New DataError
        '        objError.WriteFile(ex)
        '    Finally
        '        objService.CloseConnection()
        '    End Try

        'End Sub

        Public Sub BindDataList(ByVal strTableName As String, ByVal ctlDropDownList As DropDownList, ByVal strNeedALL As Boolean)

            'Try
            objService = New DataService
            objService.FillDataSet(strTableName, " 0 = 0 ")
            ctlDropDownList.DataSource = objService.ObjDT
            ctlDropDownList.DataBind()
            If strNeedALL = True Then ctlDropDownList.Items.Insert(0, "ALL")
            ' Catch ex As Exception
            'objError = New DataError
            '    objError.WriteFile(ex)
            ' Finally
            objService.CloseConnection()
            ' End Try

        End Sub

        Public Sub BindDataListProductcode(ByVal strTableName As String, ByVal ctlDropDownList As DropDownList, ByVal strNeedALL As Boolean)

            'Try
            objService = New DataService
            objService.FillDataSetProductcode(strTableName, " 0 = 0 ")
            ctlDropDownList.DataSource = objService.ObjDT
            ctlDropDownList.DataBind()
            If strNeedALL = True Then ctlDropDownList.Items.Insert(0, "ALL")
            ' Catch ex As Exception
            'objError = New DataError
            '    objError.WriteFile(ex)
            ' Finally
            objService.CloseConnection()
            ' End Try

        End Sub

        Public Sub BindDataListCondition(ByVal strTableName As String, ByVal strCondition As String, ByVal ctlDropDownList As DropDownList, ByVal strNeedALL As Boolean, ByVal strdistinct As String)

            'Try
            objService = New DataService
            objService.FillDataSetDistinct(strTableName, strCondition, strdistinct)
            ctlDropDownList.DataSource = objService.ObjDT
            'ctlDropDownList.DataMember = objService.objDT.Columns(1).Caption
            ctlDropDownList.DataValueField = objService.ObjDT.Columns(0).Caption
            ctlDropDownList.DataBind()
            If strNeedALL = True Then ctlDropDownList.Items.Insert(0, "ALL")
            ' Catch ex As Exception
            'objError = New DataError
            '    objError.WriteFile(ex)
            ' Finally
            objService.CloseConnection()
            ' End Try

        End Sub
        Public Sub BindDataListConditionDup(ByVal strTableName As String, ByVal strCondition As String, ByVal ctlDropDownList As DropDownList, ByVal strNeedALL As Boolean)

            'Try
            objService = New DataService
            objService.FillDataSetDup(strTableName, strCondition)
            ctlDropDownList.DataSource = objService.ObjDT
            ctlDropDownList.DataBind()
            If strNeedALL = True Then ctlDropDownList.Items.Insert(0, "ALL")
            ' Catch ex As Exception
            'objError = New DataError
            '    objError.WriteFile(ex)
            ' Finally
            objService.CloseConnection()
            ' End Try

        End Sub

        Public Sub BindDataList(ByVal strTableName As String, ByVal strCondition As String, ByVal ctlDropDownList As DropDownList, ByVal strNeedALL As Boolean)

            'Try
            objService = New DataService
            objService.FillDataSet(strTableName, strCondition)
            ctlDropDownList.DataSource = objService.ObjDT
            ' ctlDropDownList.DataMember = objService.objDT.Columns(1).Caption
            'ctlDropDownList.DataValueField = objService.objDT.Columns(1).Caption
            'ctlDropDownList.DataTextField = objService.objDT.Columns(2).Caption
            ctlDropDownList.DataBind()
            If strNeedALL = True Then ctlDropDownList.Items.Insert(0, "ALL")
            ' Catch ex As Exception
            ' objError = New DataError
            ' objError.WriteFile(ex)
            '  Finally
            objService.CloseConnection()
            ' End Try

        End Sub

        Public Sub BindDataListCenterDetails(ByVal strTableName As String, ByVal strCondition As String, ByVal ctlDropDownList01 As DropDownList, ByVal ctlDropDownList02 As DropDownList, ByVal strNeedALL As Boolean, ByVal strItem As String, ByVal strValue As String)

            'Try
            objService = New DataService
            objService.FillDataSet(strTableName, strCondition)
            ctlDropDownList01.DataSource = objService.ObjDT
            ctlDropDownList02.DataSource = objService.ObjDT
            ' ctlDropDownList.DataMember = objService.objDT.Columns(1).Caption
            ctlDropDownList01.DataValueField = objService.ObjDT.Columns(strValue).Caption
            ctlDropDownList01.DataTextField = objService.ObjDT.Columns(strItem).Caption
            ctlDropDownList01.DataBind()

            ctlDropDownList02.DataValueField = objService.ObjDT.Columns(strItem).Caption
            ctlDropDownList02.DataTextField = objService.ObjDT.Columns(strValue).Caption
            ctlDropDownList02.DataBind()


            If strNeedALL = True Then
                ctlDropDownList01.Items.Insert(0, "ALL")
                ctlDropDownList02.Items.Insert(0, "ALL")
            End If

            ' Catch ex As Exception
            ' objError = New DataError
            ' objError.WriteFile(ex)
            '  Finally
            objService.CloseConnection()
            ' End Try

        End Sub
        Public Sub BindDataListNew(ByVal strTableName As String, ByVal strCondition As String, ByVal ctlDropDownList As DropDownList, ByVal strNeedALL As String, ByVal strItem As String, ByVal strValue As String)

            'Try
            objService = New DataService
            objService.FillDataSet(strTableName, strCondition)
            ctlDropDownList.DataSource = objService.ObjDT

            ' ctlDropDownList.DataMember = objService.objDT.Columns(1).Caption
            ctlDropDownList.DataValueField = objService.ObjDT.Columns(strValue).Caption
            ctlDropDownList.DataTextField = objService.ObjDT.Columns(strItem).Caption
            ctlDropDownList.DataBind()



            If strNeedALL <> "" Then ctlDropDownList.Items.Insert(0, strNeedALL)

            ' Catch ex As Exception
            ' objError = New DataError
            ' objError.WriteFile(ex)
            '  Finally
            objService.CloseConnection()
            ' End Try

        End Sub

        Public Sub BindDataListUnion(ByVal strTableName As String, ByVal strtableName1 As String, ByVal strCondition As String, ByVal strcondition1 As String, ByVal ctlDropDownList As DropDownList, ByVal strNeedALL As String, ByVal strfield As String, ByVal strfield1 As String)

            'Try
            objService = New DataService
            objService.FillDataSetUnion(strTableName, strtableName1, strCondition, strcondition1, strfield, strfield1)
            ctlDropDownList.DataSource = objService.ObjDT

            ' ctlDropDownList.DataMember = objService.objDT.Columns(1).Caption
            ctlDropDownList.DataValueField = objService.ObjDT.Columns(strfield).Caption
            ctlDropDownList.DataTextField = objService.ObjDT.Columns(strfield).Caption
            ctlDropDownList.DataBind()



            If strNeedALL <> "" Then ctlDropDownList.Items.Insert(0, strNeedALL)

            ' Catch ex As Exception
            ' objError = New DataError
            ' objError.WriteFile(ex)
            '  Finally
            objService.CloseConnection()
            ' End Try

        End Sub
        Public Sub BindDataListUniontrifield(ByVal strTableName As String, ByVal strtableName1 As String, ByVal strtableName2 As String, ByVal strCondition As String, ByVal strcondition1 As String, ByVal strcondition2 As String, ByVal ctlDropDownList As DropDownList, ByVal strNeedALL As String, ByVal strfield As String, ByVal strfield1 As String, ByVal strfield2 As String)

            'Try
            objService = New DataService
            objService.FillDataSetUniontrifield(strTableName, strtableName1, strtableName2, strCondition, strcondition1, strcondition2, strfield, strfield1, strfield2)
            ctlDropDownList.DataSource = objService.ObjDT

            ' ctlDropDownList.DataMember = objService.objDT.Columns(1).Caption
            ctlDropDownList.DataValueField = objService.ObjDT.Columns(strfield).Caption
            ctlDropDownList.DataTextField = objService.ObjDT.Columns(strfield).Caption
            ctlDropDownList.DataBind()



            If strNeedALL <> "" Then ctlDropDownList.Items.Insert(0, strNeedALL)

            ' Catch ex As Exception
            ' objError = New DataError
            ' objError.WriteFile(ex)
            '  Finally
            objService.CloseConnection()
            ' End Try

        End Sub



        Public Sub BindDataListJoin(ByVal strQuery As String, ByVal ctlDropDownList As DropDownList, ByVal strNeedALL As String, ByVal strItem As String, ByVal strValue As String)

            'Try
            objService = New DataService
            'objService.FillDataSet(strTableName, strCondition)
            objService.FillDataSetQueryJoin(strQuery)
            ctlDropDownList.DataSource = objService.ObjDT

            ' ctlDropDownList.DataMember = objService.objDT.Columns(1).Caption
            ctlDropDownList.DataValueField = objService.ObjDT.Columns(strValue).Caption
            ctlDropDownList.DataTextField = objService.ObjDT.Columns(strItem).Caption
            ctlDropDownList.DataBind()



            If strNeedALL <> "" Then ctlDropDownList.Items.Insert(0, strNeedALL)

            ' Catch ex As Exception
            ' objError = New DataError
            ' objError.WriteFile(ex)
            '  Finally
            objService.CloseConnection()
            ' End Try

        End Sub
        Public Sub ShowPanelOrGrid(ByVal strTableName As String, ByVal strCondition As String, ByVal ctlPanel As Panel, ByVal ctlDG As DataGrid, ByVal lblPCounter As Label, ByVal lblTotal As Label)

            Try
                objService = New DataService
                If objService.FunExecuteScalar(strTableName, strCondition) = 0 Then
                    ctlPanel.Visible = True
                    ctlDG.Visible = False
                    lblPCounter.Visible = False
                    lblTotal.Visible = False
                Else
                    ctlDG.Visible = True
                    lblPCounter.Visible = True
                    lblTotal.Visible = True
                    ctlPanel.Visible = False
                End If
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally
                objService.CloseConnection()
            End Try

        End Sub

        Public Sub BindDataGridSelect(ByVal strTableName As String, ByVal strCondition As String, ByVal ctlDataGrid As GridView, ByVal SelectField As String)

            Try
                objService = New DataService

                objService.FillDataSetSelect(strTableName, strCondition, SelectField)

                If objService.ObjDT.Rows.Count <> 0 Then
                    ctlDataGrid.DataSource = objService.ObjDT
                    ctlDataGrid.DataBind()
                Else
                    objService.objDS.Tables(0).Rows.Add(objService.objDS.Tables(0).NewRow())
                    'objService.objDT.Rows.Add(objService.objDT.NewRow())
                    ctlDataGrid.DataSource = objService.ObjDT
                    ctlDataGrid.DataBind()
                    Dim columncount As Integer = ctlDataGrid.Rows(0).Cells.Count
                    ctlDataGrid.Rows(0).Cells.Clear()
                    ctlDataGrid.Rows(0).Cells.Add(New TableCell())
                    ctlDataGrid.Rows(0).Cells(0).ColumnSpan = columncount
                    ctlDataGrid.Rows(0).Cells(0).Text = " No records Found to Display ! "
                End If
                'ctlDataGrid.DataBind()
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally
                objService.CloseConnection()
            End Try

        End Sub
        Public Sub BindDataGridSelect(ByVal ctlDataGrid As GridView, ByVal strquery As String, ByVal tablename As String)

            Try
                objService = New DataService
                objService.FillDataSetQuery(strquery, tablename)

                If objService.ObjDT.Rows.Count <> 0 Then
                    ctlDataGrid.DataSource = objService.ObjDT
                    ctlDataGrid.DataBind()
                Else
                    objService.objDS.Tables(0).Rows.Add(objService.objDS.Tables(0).NewRow())
                    'objService.objDT.Rows.Add(objService.objDT.NewRow())
                    ctlDataGrid.DataSource = objService.ObjDT
                    ctlDataGrid.DataBind()
                    Dim columncount As Integer = ctlDataGrid.Rows(0).Cells.Count
                    ctlDataGrid.Rows(0).Cells.Clear()
                    ctlDataGrid.Rows(0).Cells.Add(New TableCell())
                    ctlDataGrid.Rows(0).Cells(0).ColumnSpan = columncount
                    ctlDataGrid.Rows(0).Cells(0).Text = " No records Found to Display ! "
                End If
                'ctlDataGrid.DataSource = objService.objDT
                'ctlDataGrid.DataBind()
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally
                objService.CloseConnection()
            End Try

        End Sub
        Public Sub BindDataGridSelectJoin(ByVal ctlDataGrid As GridView, ByVal strquery As String)

            Try
                objService = New DataService
                objService.FillDataSetQueryJoin(strquery)


                If objService.ObjDT.Rows.Count <> 0 Then
                    ctlDataGrid.DataSource = objService.ObjDT
                    ctlDataGrid.DataBind()
                Else
                    objService.objDS.Tables(0).Rows.Add(objService.objDS.Tables(0).NewRow())
                    'objService.objDT.Rows.Add(objService.objDT.NewRow())
                    ctlDataGrid.DataSource = objService.ObjDT
                    ctlDataGrid.DataBind()
                    Dim columncount As Integer = ctlDataGrid.Rows(0).Cells.Count
                    ctlDataGrid.Rows(0).Cells.Clear()
                    ctlDataGrid.Rows(0).Cells.Add(New TableCell())
                    ctlDataGrid.Rows(0).Cells(0).ColumnSpan = columncount
                    ctlDataGrid.Rows(0).Cells(0).Text = " No records Found to Display ! "
                End If


                'ctlDataGrid.DataSource = objService.objDT
                'ctlDataGrid.DataBind()
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally
                objService.CloseConnection()
            End Try

        End Sub

        Public Sub BindDataListSelected(ByVal strTableName As String, ByVal strCondition As String, ByVal strCondition2 As String, ByVal ctlDropDownList As DropDownList, ByVal strNeedALL As String, ByVal strItem As String, ByVal strValue As String)

            'Try
            objService = New DataService
            objService.FillDataSetSelectedField(strTableName, strCondition, strCondition2)
            ctlDropDownList.DataSource = objService.ObjDT

            ' ctlDropDownList.DataMember = objService.objDT.Columns(1).Caption
            ctlDropDownList.DataValueField = objService.ObjDT.Columns(strValue).Caption
            ctlDropDownList.DataTextField = objService.ObjDT.Columns(strItem).Caption
            ctlDropDownList.DataBind()



            If strNeedALL <> "" Then ctlDropDownList.Items.Insert(0, strNeedALL)

            ' Catch ex As Exception
            ' objError = New DataError
            ' objError.WriteFile(ex)
            '  Finally
            objService.CloseConnection()
            ' End Try

        End Sub
        Public Sub BindDataList(ByVal strTableName As String, ByVal strCondition As String, ByVal ctlDropDownList As DropDownList, ByVal strNeedALL As String, ByVal strItem As String, ByVal strValue As String, ByVal strselectedfield As String)

            'Try
            objService = New DataService
            objService.FillDataSetspl(strTableName, strCondition, "", strselectedfield)
            ctlDropDownList.DataSource = objService.ObjDT

            ' ctlDropDownList.DataMember = objService.objDT.Columns(1).Caption
            ctlDropDownList.DataValueField = objService.ObjDT.Columns(strValue).Caption
            ctlDropDownList.DataTextField = objService.ObjDT.Columns(strItem).Caption
            ctlDropDownList.DataBind()



            If strNeedALL <> "" Then ctlDropDownList.Items.Insert(0, strNeedALL)

            ' Catch ex As Exception
            ' objError = New DataError
            ' objError.WriteFile(ex)
            '  Finally
            objService.CloseConnection()
            ' End Try

        End Sub
    End Class
End Namespace
