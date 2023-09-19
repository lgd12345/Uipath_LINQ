'Option Explicit '명시적선언함 각 변수의 타입에 대한 정의가 되어있어야함

Public Sub SortCopyPasteExcel()

'변수선언
Dim copyCol As Range
Dim pasteCol As Range

Dim RowCnt As Long

Application.ScreenUpdating = False '엑셀의 화면 업데이트를 비활성화 코드빠르게실행

'변수할당
Set copyCol = Sheets("Sheet1").UsedRange 'Set는 개체변수에만 사용
Set pasteCol = Sheets("xheet3").UsedRange

'서식 복사 붙여넣기 실행
copyCol.Copy
pasteCol.PasteSpecial xlPasteFormats
Application.CutCopyMode = False ' 복사한 서식 붙여넣기 완료 후 클립보드 비우기

RowCnt = Sheets("Sheet1").UsedRange.Rows.Count + 1    'ActiveSheet.UsedRange.이거 안 써봐서 모름

Set copyCol = Sheets("Sheet1").Range("D1:D" & RowCnt)
Set pasteCol = Sheets("xheet3").Range("H1:H" & RowCnt)

copyCol.Copy
pasteCol.PasteSpecial xlPasteFormats

Application.CutCopyMode = False ' 복사한 서식 붙여넣기 완료 후 클립보드 비우기
Application.ScreenUpdating = True  '화면업데이트
    


End Sub
