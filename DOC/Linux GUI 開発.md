# Linux GUI 開発

Windowsでは比較的簡単に GUI ソフトウェア開発が出来るが、Linuxでは敷居が高い感じ。

GUI開発したい。手っ取り早くGUI出来る環境構築したい。

「MonoDevelop」環境構築を行い使ってみる。



手順は以下の通り。

* "mono"をインストール
* "monodevelop"をインストール
* "monodevelop"起動



## "Mono"

公式ページ(https://www.mono-project.com/download/stable/#download-lin)の手順に従いMonoをインストールする

### Ubuntu 18.04

```
sudo apt install gnupg ca-certificates
sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
echo "deb https://download.mono-project.com/repo/ubuntu stable-bionic main" | sudo tee /etc/apt/sources.list.d/mono-official-stable.list
sudo apt update
```



Install Mono

```
sudo apt install mono-devel
```



## "MonoDevelop"

公式ページ(https://www.monodevelop.com/download/#fndtn-download-lin)の手順に従いインストール。



### Ubuntu 18.04

```
sudo apt install apt-transport-https dirmngr
sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
echo "deb https://download.mono-project.com/repo/ubuntu vs-bionic main" | sudo tee /etc/apt/sources.list.d/mono-official-vs.list
sudo apt update
```



Install MonoDevelop

```
sudo apt-get install monodevelop
```



ここまでで準備完了。



## "MonoDevelop"起動

consoleから"monodevelop"と入力する事で起動する。



1. "新しいプロジェクト"を選択
2. "Gtk# 2.0プロジェクト"を選択
3. ひとまず完了



あとはVisualStudioのように部品配置しながらコード書く....

Linuxはツンデレなので、イベントなどダブルクリックしてもコードに飛んでくれない...(泣き)



## 注意

フォーム作成時、VisualStudioのようにいきなりボタンなど配置しようとしてもダメ。

まずは「fixed」を配置する必要あり。



### やってみよう

1. MonoDevelopを起動する。

![image-20220419181011523](L:\Fujinuki\TMP\Typora_Work\Linux GUI 開発\image-20220419181011523.png)





2. "New Project"をクリックして新しいプロジェクト作成を選択

* Other

  * .NET

  の順番にクリック

* "Gtk# 2.0 Project (C#)"を選択
* 画面右下 "Next"をクリック



3. プロジェクト名などを入力し"Create"

   ![image-20220419181819734](L:\Fujinuki\TMP\Typora_Work\Linux GUI 開発\image-20220419181819734.png)

4. プロジェクト作成完了。

   新規プロジェクト作成完了となると、基本コードが表示される感じ。

   ![image-20220419181923735](L:\Fujinuki\TMP\Typora_Work\Linux GUI 開発\image-20220419181923735.png)

5. "MainWindows.cs"をダブルクリック

   画面下に"Source"、"Designer"が表示される。

   ![image-20220419182029459](L:\Fujinuki\TMP\Typora_Work\Linux GUI 開発\image-20220419182029459.png)

6. "Designer"をクリックするとWindowレイアウトとなる。

   ![image-20220419182113215](L:\Fujinuki\TMP\Typora_Work\Linux GUI 開発\image-20220419182113215.png)

7. 【重要】最初の一歩

   Windows開発を行う場合VisualStudioなどはこの状態にてボタンなど配置できるけど...

   MonoDevelopはこの状態にてボタンなどを配置しようとするとWindowのサイズになってしまう。

   "Toolbox"から"Fixed"を選択しWindowへ配置する。

   ![image-20220419182336956](L:\Fujinuki\TMP\Typora_Work\Linux GUI 開発\image-20220419182336956.png)

8. こんな感じ

   ![image-20220419182412784](L:\Fujinuki\TMP\Typora_Work\Linux GUI 開発\image-20220419182412784.png)

9. これでOK

   この状態となれば、"Toolbox"からlabelやbuttonなどを配置が可能となる。

   ![image-20220419182533192](L:\Fujinuki\TMP\Typora_Work\Linux GUI 開発\image-20220419182533192.png)

   あとはコードを書いていくのみ!!

   ボタンなどのイベントはプロパティを開いて設定する (VisualStudioと一緒)

   VisualStudioの場合、イベントにてダブルクリックする事で当該イベント処理コードへ勝手に移行してくれるのだが、MonoDevelopでは飛んでくれないので、画面下の"Source"にて切り替える一手間が必要。

   

   あとはBuildして実行すればOK。

   

---

# C++ (gtk+ / Glade の場合)

linuxにてC++を用いた開発を行う場合、GUI対応が難しい。

GUI対応を行う場合は "gtk+"を用いる事が一般的らしい。

しかし"gtk+"はGUIを扱えるがフォームデザイナが無いので、そのままでは直感的なフォーム作成できない。

フォームデザインを行う場合は "Glade"を使用しデザインを行うらしい。



* C++開発環境
* VScodeインストール
* gtk+
* glade



## C++開発環境

基本開発環境インストール

```
sudo apt install -y build-essential
```



CMakeインストール

```
sudo apt install -y cmake
```



## VScode install

[MicroSoft VisualStudio Code](https://azure.microsoft.com/ja-jp/products/visual-studio-code/)のページへアクセス

「今すぐダウンロード」をクリック。

![image-20220422155348943](L:\Fujinuki\TMP\Typora_Work\Linux GUI 開発\image-20220422155348943.png)



該当するパッケージ選択

![image-20220422155419338](L:\Fujinuki\TMP\Typora_Work\Linux GUI 開発\image-20220422155419338.png)

ダウンロードフォルダへファイルが保存される。

ファイル上にて右クリックしinstallを行う。

![image-20220422155542493](L:\Fujinuki\TMP\Typora_Work\Linux GUI 開発\image-20220422155542493.png)

![image-20220422155608207](L:\Fujinuki\TMP\Typora_Work\Linux GUI 開発\image-20220422155608207.png)



## gtk+ / glade install

以下のコマンドにてインストール (Version 3)

```
sudo apt install -y libgtk-3-dev
sudo apt install -y glade
```

* gladeは gtk+ Version4との相性がイマイチらしい。
* "GtkBuilder"の仕様とかみ合わない実装が存在するらしい。
* 一先ず Version3 にて試す事とする。









```
gcc test.c `pkg-config --libs --cflags gtk+-3.0` -o p
```











