Sub SortExcelSheets()
'값을 반환 안 할 것이고 입력 매개변수가 없다.

Application.ScreenUpdating = False

Dim iSheets%, i%, j%
iSheets = Sheets.Count

For i = 1 To iSheets-1
    For j = i + 1 To iSheets
        If Sheets(j).Name < Sheets(i).Name Then
            Sheets(j).Move before:=Sheets(i)
        End If
    Next j
Next i

Application.ScreenUpdating = True

End Sub