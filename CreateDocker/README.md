Dockerイメージを手元で作成して、ACSにUploadしてApp Service on Linuxに配置するデモ。

$ dotnet restore
$ dotnet public -c Release

$ docker build . -f Dockerfile -t myaspnetcore:0.1
//手元で動作確認する場合
$ docker run -d -p 7070:8080 myaspnetcore:0.1 

$ docker tag myaspnetcore:0.1 tanaka733-on.azurecr.io/myaspnetcore:0.1
$ docker push tanaka733-on.azurecr.io/myaspnetcore:0.1

あとはApp Service側でこのdockerイメージを参照する