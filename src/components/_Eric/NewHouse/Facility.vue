<template>
  <button @click="choose">
    <div class="item">
      <div class="icon">
        <slot></slot>
      </div>
      <div class="name"></div>
    </div>
  </button>
</template>

<style lang="scss" scoped>
.item {
  display: flex;
  color: #000;
  cursor: pointer;
  align-items: center;
  padding: 24px 16px;

  box-sizing: border-box;
  width: 100%;
  justify-content: space-between;
  font-size: 18px;
  font-weight: 900;
}

button {
  text-decoration: none;
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
  background-color: #fff;
  border: none;
  width: 100%;
  padding: 0;
  border: 2px solid #ddd;
  border-radius: 12px;

  &:hover {
    border-color: #000;
  }

  &.active {
    border-color: #000;
  }
}

svg {
  display: block;
  height: 52px;
  width: 52px;
  fill: currentColor;
}
</style>


<script>
export default {
  props: {},
};
</script>

