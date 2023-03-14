Partial Class Database1DataSet
    Partial Public Class EqualDBDataTable
        Private Sub EqualDBDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ΦΠΑColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
