<template>
  <li v-for="houseType in houseTypes" :key="houseType.mapping">
    <HouseType :houseType="houseType"></HouseType>
  </li>
</template>

<style lang="scss" scoped>
li {
  list-style: none;
  padding: 0;
}
</style>
<script>
import HouseType from "./HouseType.vue";

export default {
  props: {
    houseTypes: {
      type: Object,
    },
  },
  components: {
    HouseType,
  },
};
</script>