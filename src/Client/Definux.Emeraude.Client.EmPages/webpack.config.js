const path = require('path');
const UglifyJsPlugin = require('uglifyjs-webpack-plugin');

module.exports = {
    target: 'node',
    resolve: {
        extensions: [ '.ts', '.js' ]
    },
    module: {
        rules: [
            { test: /\.ts$/, use: 'ts-loader' },
            { test: /\.js$/, loader: 'babel-loader' }
        ]
    },
    entry: {
        'render-on-server': ['./TypeScript/RenderOnServer']
    },
    output: {
        libraryTarget: 'commonjs',
        path: path.join(__dirname, 'Content', 'Node'),
        filename: '[name].js'
    },
    optimization: {
        minimize: true,
        minimizer: [
            new UglifyJsPlugin({
                uglifyOptions: {
                    output: {
                        comments: false
                    }
                }
            })
        ]
    }
};
