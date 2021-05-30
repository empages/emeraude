const emeraudeConfig = require('emeraude-config');

module.exports = () => {
    return emeraudeConfig({
        appEntry: './ClientApp/main.js',
        publicPath: '/dist',
        serverConfig: {

        },
        clientConfig: {

        }
    });
};