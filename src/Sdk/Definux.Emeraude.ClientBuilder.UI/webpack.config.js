const path = require('path');
const webpack = require('webpack');
const VueLoaderPlugin = require('vue-loader/lib/plugin');
const isDevelopment = !(process.env.NODE_ENV && process.env.NODE_ENV === 'production');

module.exports = {
    mode: isDevelopment ? 'development' : 'production',
    devtool: '',
    stats: { modules: false },
    resolve: { extensions: ['.js', '.vue'] },
    entry: './ClientApp/main.js',
    output: {
        filename: 'client-builder.js',
        path: path.join(__dirname, 'wwwroot', 'admin', 'js', 'modules'),
        publicPath: '/admin/js/modules/'
    },
    module: {
        rules: [
            {
                test: /\.vue$/,
                loader: 'vue-loader'
            },
            {
                test: /\.js$/,
                loader: 'babel-loader',
                include: '/admin/js/vue',
                exclude: file => (
                    /node_modules/.test(file) &&
                    !/\.vue\.js/.test(file)
                )
            },
            {
                test: /\.css$/,
                oneOf: [
                    {
                        resourceQuery: /module/,
                        use: [
                            'vue-style-loader',
                            {
                                loader: 'css-loader',
                                options: {
                                    modules: true,
                                    localIdentName: '[local]_[hash:base64:5]'
                                }
                            }
                        ]
                    },
                    {
                        use: [
                            'vue-style-loader',
                            'css-loader'
                        ]
                    }
                ]

            },
            {
                test: /\.scss$/,
                use: [
                    'vue-style-loader',
                    'css-loader',
                    {
                        loader: 'sass-loader'
                    }
                ]
            },
            {
                test: /\.(png|jpg|jpeg|gif|svg)$/,
                loader: 'url-loader?limit=25000'
            }
        ]
    },
    plugins: [
        new VueLoaderPlugin()
    ]
};