Sub SortExcelSheets()
'값을 반환 안 할 것이고 입력 매개변수가 없다.Sub쓴다

Application.ScreenUpdating = False '엑셀의 화면 업데이트를 비활성화 코드빠르게실행

Dim iSheets%, i%, j%  '변수정의
iSheets = Sheets.Count  '변수에 시트 수 할당

For i = 1 To iSheets-1  '시트 수로 반복 루프
    For j = i + 1 To iSheets  'i 보다 큰 값으로 반복루프2
        If Sheets(j).Name < Sheets(i).Name Then '시트 순서에 따라 이름을 비교한다. 뒤(j)에 있는 시트가 크면
            Sheets(j).Move before:=Sheets(i)  '뒤에(j)시트를 i시트 앞으로 이동
        End If
    Next j
Next i

Application.ScreenUpdating = True  '화면업데이트

End Sub