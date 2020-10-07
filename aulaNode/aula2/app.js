var http = require("http");
var operacoes = require("./operacoes");

http.createServer(function (req, res) {
  res.writeHead(200, {"Content-Type": "text/html"});
  res.write("A soma de 7 + 7 = " + operacoes.adicao(7, 7) + 
  	"<br> A soma de 7 - 7 = " + operacoes.subtracao(7, 7)
  	);
  res.end();
}).listen(8081);