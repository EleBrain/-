
子要素を消すとき
foreach (Transform item in transform) {
    Destroy(item.gameObject);
}

foreach (var item in transform) {
にするとvarはobjectになる

DestroyできるのはgameObject
foreach中にDestroyしてもOK



必須コンポーネント
[RequireComponent(typeof (必須コンポーネント名))]
public class a : MonoBehaviour {


ファイルの名前を変えるときはVS側で変えるとエラーが出ないよ

UnityVSを別のフォルダに入れないこと

recttransformの位置を動かすとき
　rectTransform.position = new Vector3(0, 0, 0);
  rectTransform.anchoredPosition = new Vector2(0, 0);
サイズ変えるとき
　sizeDelta = new Vector2(0, 0);



キーボード
if (Input.GetKey(KeyCode.UpArrow)) {
  //アップデートごとに呼ばれる
} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
  //1回だけ
}

イベントシステムでマウスオーバーを取得できない　
　マウスエンターデフラグをオン
　マウスイグジットでフラグをオフにする



チャットメモ
if (text.text　!= "" ) { //1行目かどうかチェック
    text.text += "\r\n";　//まず改行
}
text.text += Field.text;　//そしてテキスト追加
text.rectTransform.sizeDelta = new Vector2(text.rectTransform.sizeDelta.x, text.preferredHeight);　テキストフィールドのサイズ変更

viewScrollbar.value = 0.01f;　//1回別の値にしてからじゃないと無視される時がある
viewScrollbar.value = 0;　　　//位置を一番最後に

Field.text = "";　　　　　　//インプットフィールドの文字をクリア
Field.ActivateInputField();　//もう一度フォーカスをインプットフィールドに
