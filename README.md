# CalculatorApp

## 概要

`CalculatorApp`は、基本的な四則演算を提供するシンプルなWindowsフォームアプリケーションです。  
本プロジェクトはC#で実装され、.NET Framework 4.8を使用しています。

## 開発環境

- Windows 11
- Visual Studio 2022

## 使用バージョン

- .NET Framework 4.8

## 依存パッケージ

- log4net(2.0.17)

## 機能

- 基本的な四則演算（加算、減算、乗算、除算）
- 小数点以下5桁までの計算
- ログ出力
  - デバッグビルドの場合は、Visual Studioの出力ウィンドウ
  - リリースビルドの場合は、実行ファイルと同じディレクトリに`log.txt`として保存
- キーボードによる操作

## プロジェクト構成(主要ファイルのみ抜粋)

```plane text
CalculatorApp
├── Models
│     ├── AdditionOperation.cs : 加算の実装クラス
│     ├── BaseButton.cs : 基本ボタンクラス
│     ├── CalculatorButton.cs : 電卓用ボタンクラス
│     ├── DivisionOperation.cs : 除算の実装クラス
│     ├── IOperation.cs : 四則演算用のインターフェース
│     ├── MultiplicationOperation.cs : 乗算の実装クラス
│     └── SubtractionOperation.cs : 減算の実装クラス
├── Resources
│     └── backspace.png : バックスペースボタン用の画像ファイル
├── ViewModels
│     └── CalculatorViewModel.cs : ビジネスロジックとデータバインディング管理クラス
├── View
│     ├── MainForm.cs : 電卓画面
│     ├── MainForm.Designer.cs
│     └── MainForm.resx
├── App.config
├── log4net.config : log4netの設定ファイル
└── Program.cs
```
