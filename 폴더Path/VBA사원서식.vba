Option Explicit '명시적선언함 각 변수의 타입에 대한 정의가 되어있어야함

Public Sub SortCopyPasteExcel()

'변수선언
Dim copyCol As Range
Dim pasteCol As Range

Application.ScreenUpdating = False '엑셀의 화면 업데이트를 비활성화 코드빠르게실행

'변수할당
Set copyCol = Sheets("Sheet1").UsedRange
Set pasteCol = Sheets("Sheet2").UsedRange
    
'서식 복사 붙여넣기 실행
copyCol.Copy
pasteCol.PasteSpecial xlPasteFormats

Application.ScreenUpdating = True  '화면업데이트
    
Application.CutCopyMode = False ' 복사한 서식 붙여넣기 완료 후 클립보드 비우기

End Sub
