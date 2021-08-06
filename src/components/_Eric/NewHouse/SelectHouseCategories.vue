<template>
  <li v-for="houseType in houseCategories" :key="houseType.mapping">
    <HouseCategory :houseType="houseType"></HouseCategory>
  </li>
</template>

<style lang="scss" scoped>
li {
  list-style: none;
  padding: 0;
}
</style>

<script>
import setting from "./setting";
import HouseCategory from "./HouseCategory.vue";
export default {
  data() {
    return { houseCategories: setting.houseCategories };
  },
  components: {
    HouseCategory,
  },
};
</script>