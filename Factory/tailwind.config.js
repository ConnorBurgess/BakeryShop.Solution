module.exports = {
  purge: [],
  darkMode: false, // or 'media' or 'class'
  theme: {
    extend: {
      backgroundImage: theme => ({
        'BakeryShop-pattern': "url('')",

      }),
      keyframes: {
        wiggle: {
          '0%, 100%': { transform: 'rotate(-3deg)' },
          '50%': { transform: 'rotate(3deg)' },
        }
      },
      animation: {
        wiggle: 'wiggle 3s ease-in-out infinite',
      },
    },
    container: {

    },
  },
  variants: {
    extend: {},
  },
  plugins: [],
}
