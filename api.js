var Db = require('./dbcrud')
var express = require('express')
var bodyParser = require('body-parser')
var cors = require('cors')
var app = express()
var router = express.Router()

app.use(bodyParser.urlencoded({ extended: true}))
app.use(bodyParser.json())
app.use(cors())
app.use('/api', router)

router.use((request, response, next) => {
    console.log("SERVER IN FUNZIONE...")
    next()
});

router.route("/bottiglie").get((request, response) => {
    Db.getElencoBottiglie().then((data) => {
        response.json(data[0])
    })
})

router.route('/bottiglie/:id').get((request, response) => {
    Db.getBottiglia(request.params.id).then((data) => {
      response.json(data[0]);
    })
  })
  
router.route("/desc").get((request, response) => {
  Db.getBottiglieByDescPrice().then((data) => {
      response.json(data[0])
  })
})

router.route("/asc").get((request, response) => {
  Db.getBottiglieByAscPrice().then((data) => {
      response.json(data[0])
  })
})

router.route("/new").get((request, response) => {
  Db.getBottiglieByNewest().then((data) => {
      response.json(data[0])
  })
})

router.route("/recensioni").get((request, response) => {
  Db.getRecensioni().then((data) => {
      response.json(data[0])
  })
})

var port = process.env.PORT || 8090
app.listen(port)
console.log("Le API Recensioni sono in ascolto sulla porta " + port)