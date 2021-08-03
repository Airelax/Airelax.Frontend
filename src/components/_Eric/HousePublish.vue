<template>
  <router-link to="/">
    <div class="cover">
      <img :src="houseSource.img" />
    </div>
    <span>{{ houseSource.title }}</span>
    <div class="icon">
      <svg
        viewBox="0 0 32 32"
        xmlns="http://www.w3.org/2000/svg"
        role="presentation"
        focusable="false"
      >
        <g fill="none">
          <path
            d="m12 4 11.2928932 11.2928932c.3905243.3905243.3905243 1.0236893 0 1.4142136l-11.2928932 11.2928932"
          ></path>
        </g>
      </svg>
    </div>
  </router-link>
</template>

<style lang="scss" scoped>
a {
  display: block;
  text-decoration: none;
  color: #000;
  cursor: pointer;
  display: flex;
  align-items: center;

  .cover {
    width: 32px;
    height: 32px;
  }

  .icon svg {
    display: block;
    fill: none;
    height: 16px;
    width: 16px;
    stroke: currentcolor;
    stroke-width: 4;
    overflow: visible;
  }
}
</style>


<script>
export default {
  props: {
    houseSource: {
      type: Object,
      default: () => {
        return { img: "https://fakeimg.pl/32x32/#141372", title: "防員測試" };
      },
    },
  },
};
</script>