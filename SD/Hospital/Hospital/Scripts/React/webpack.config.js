﻿module.exports = {
  context: __dirname,
  entry: "./app.js",
  mode: "development",
  output: {
    path: __dirname + "/dist",
    filename: "bundle.js"
  },

  // watch: true,
  module: {
    rules: [
      {
        test: /\.js$/,
        exclude: /(node_modules|bower_components)/,
        use: {
          loader: "babel-loader",
          options: {
            presets: ["@babel/preset-env", "@babel/preset-react"]
          }
        }
      }
    ]
  }
};
