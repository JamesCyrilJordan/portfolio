module.exports = {
    parser: '@babel/eslint-parser',
    parserOptions: {
        requireConfigFile: false,
    },
    overrides: [
        {
            files: ['src/views/*.vue'], // Adjust path as needed
            parserOptions: {
                requireConfigFile: false, // Ensures Babel doesn't complain
            },
        },
    ],
};
