<template>
  <button @click="choose">
    <div class="item">
      <div class="all-center">
        <div class="title">{{ houseType.chinese }}</div>
        <div class="description">{{ houseType.description }}</div>
      </div>
    </div>
  </button>
</template>

<style lang="scss" src="../../../assets/css/rentSelection.scss" scoped >
</style>

<style lang="scss" scoped>
.all-center {
  display: flex;
  flex-wrap: wrap;
  align-items: center;
  justify-content: center;
  text-align: left;

  .title,
  .description {
    width: 100%;
    text-align: left;
  }
}
</style>

<script>
export default {
  props: {
    houseType: () => {},
  },

  mounted() {
    console.log(this.houseType);
  },
};
</script>