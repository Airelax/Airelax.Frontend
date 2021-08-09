<template>
  <div class="my-row" v-for="item in com" :key="item.id">
    <div class="box">
      <div class="user">
        <img src="https://picsum.photos/56/56/?random=1" />
        <div class="item">
          <span>{{item.name}}</span>
          <span>{{item.date}}</span>
        </div>
      </div>
      <div class="massage">
        <p>{{item.content}}</p>
        <div class="allMsg">
          <span><u>顯示更多內容</u></span>
        </div>
      </div>
    </div>
  </div>
</template>

<style scoped>
  .my-row * {
    color: #222;
  }
  .my-row {
    height: 236px;
    padding: 16px;
    border: 1px solid rgb(221, 221, 221);
    border-radius: 12px;
    margin-right: 12px;
  }
  .my-row:nth-child(6) {
    margin-right: 0;
  }
  .box {
    width: 75.103vw;
  }
  .user {
    display: flex;
    margin-bottom: 12px;
  }
  .user img {
    width: 45px;
    height: 45px;
    border-radius: 50%;
  }
  .item {
    padding-left: 12px;
    margin: 0;
    display: flex;
    flex-direction: column;
    text-align: start;
  }
  .item span:nth-child(1) {
    font-size: 16px;
    font-weight: 600;
  }
  .item span:nth-child(2) {
    color: #717171;
    font-size: 14px;
  }
  .massage {
    text-align: initial;
  }
  .massage p {
    text-align: justify;
    margin-bottom: 0;
  }
  .allMsg {
    cursor: pointer;
    width: 124px;
    display: none;
  }
  .allMsg::after {
    content: "";
    display: inline-block;
    border: 8px solid transparent;
    border-left: 8px solid #222;
    border-radius: 50%;
    position: relative;
    top: 2px;
  }
  .allMsg span {
    font-weight: 600;
  }
  .allMsg span::after {
    content: "";
    display: inline-block;
    border: 6px solid transparent;
    border-left: 6px solid #fff;
    position: relative;
    z-index: 1;
    left: 11px;
  }
  @media screen and (min-width: 768px) {
    .my-row {
      height: 132px;
      border: none;
      padding: 0;
      margin-right: 0;
    }
    .my-row:nth-child(6) {
      margin-right: 0;
    }
    .box {
      width: 100%;
    }
    .user img {
      width: 56px;
      height: 56px;
    }
    .item {
      margin: auto 0;
    }
  }
  @media screen and (min-width: 1280px) {
    .my-row {
      width: 50%;
      height: 136px;
      padding: 0 calc(5.958rem + 8px) 0 8px;
    }
    .user {
      margin-bottom: 16px;
    }
  }
</style>

<script>
  export default {
    props: ["com"],
  };
</script>