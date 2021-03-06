# TotientQuizApp  
  
## アプリの説明  
トーシェントクイズというクイズの得点換算をしやすくすることを目的としたアプリです。  
Windows フォームを使って作成しました。元コードの言語はC#であります。  
  
## クイズの概要  
トーシェントクイズは、現在の問題数をnとして正解or不正解した者にφ(n)点を加点or減点するクイズです。  
φ(n): 1からnまでの整数で、nと互いに素な整数の個数  
例: φ(1) = 1, φ(5) = 4, φ(31) = 30  
素数pの場合φ(p) = p-1であり、一般に大きい点数となります。素数問目で正答すると非常に有利に進められると思われます。  
通常は30問目からスタートするらしいです。一応1問目からスタートするようにしてありますが、書き換えても問題ないです。  
  
## オプション  
- 順位システムを導入しており、上位3人まで冠マークが表示されます。  
- 今回の問題に正解すると何点獲得できるかが表示されます。  
- 操作ミスした場合の戻るボタンが設置されています。
  
## 目的  
[山形大学医学部クイズ研究会(@YMQS912)](https://twitter.com/YMQS912)向けの支援用アプリとして開発しています。  
もし、他のクイズ研究会でお使いいただけるならば、こちらとしても幸いです。  

## 使用法  
TotientQuiz/bin/Release内のTotientQuiz.exeを実行するとお使いいただけます。  
このexeファイルは移動させても問題ありませんが、同じフォルダ内にある「img」フォルダを一緒に動かしてください。
そうしないと正常に動作しません。  
ソースコードも残してあるので「このUI or コード **クソ** だな」と思った人はぜひ書き換えてください。  
  
## イラスト
- 王冠のアイコン  
Frame-illust 様より  
https://frame-illust.com/  
  
トーシェントクイズを楽しまれることをお祈りします。  

## ライセンス
GPL ver3.0. 改変・二次配布は自由ですが、配布時はオープンソース化してください。
また、本ゲームで使用している画像を用いる場合、Frame-illust 様の著作権表示は任意ですが、できれば表示してください。
