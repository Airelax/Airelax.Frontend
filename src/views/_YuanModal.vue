<template>
  <div class="box">
    <div class="thead">
      <div class="upHalf">
        <div class="title">
          <div class="star"></div>
          <h2 v-if="data.rank">{{data.rank.star}}．{{data.comments.length}}則評價</h2>
        </div>
        <div class="search">
          <div class="icon"></div>
          <input type="text" placeholder="搜尋評價" />
        </div>
      </div>
    </div>
    <div class="my-modal">
      <div class="sumChar">
        <Comment :rank="data.rank"></Comment>
      </div>
      <div class="scrollbar">
        <Message :com="data.comments"></Message>
      </div>
    </div>
  </div>
</template>

<style scoped>
  .box * {
    font-family: Circular, -apple-system, BlinkMacSystemFont, Roboto,
      "Helvetica Neue", sans-serif;
    /* outline: 1px solid red; */
  }
  .box {
    height: 70%;
    outline: 1px solid;
    margin: auto;
    padding: 0 24px;
  }
  .upHalf {
    padding: 0 8px;
  }
  .title {
    display: flex;
    align-items: center;
    margin-bottom: 24px;
  }
  .title .star {
    width: 24px;
    height: 24px;
    background-color: red;
    margin-right: 12px;
  }
  .title h2 {
    font-size: 26px;
    font-weight: 800;
    margin: 0;
  }
  .search {
    background-color: rgb(247, 247, 247);
    width: 100%;
    font-size: 14px;
    font-weight: 600;
    color: #222;
    padding: 11px;
    border: 1px solid rgb(176, 176, 176);
    border-radius: 44px;
    display: flex;
    margin-bottom: 24px;
  }
  .search:focus-within {
    padding: 10px;
    border: 2px solid #222;
    border-radius: 44px;
  }
  .search input {
    background-color: rgb(247, 247, 247);
    font-weight: 400;
    color: rgb(34, 34, 34);
    border: none;
    outline: none;
    width: 100%;
    height: 20px;
  }
  .icon {
    width: 13px;
    height: 13px;
    border: 1px solid #222;
    border-radius: 100%;
    margin: 0 12px 0 6px;
  }
  .icon::before {
    content: "";
    display: flex;
    width: 6px;
    height: 1px;
    background-color: #222;
    transform: rotate(45deg);
    position: relative;
    top: 12px;
    left: 9px;
  }
  .sumChar {
    width: 100%;
  }
  .scrollbar {
    margin-top: 32px;
  }
  @media screen and (min-width: 768px) {
    .sumChar {
      display: flex;
      flex-wrap: wrap;
    }
    .scrollbar {
      width: 100%;
      display: block;
    }
  }
  @media screen and (min-width: 1280px) {
    .box {
      width: 1024px;
    }
    .upHalf {
      padding: 0;
      display: flex;
    }
    .scrollbar {
      width: 71.759%;
      display: flex;
      flex-wrap: wrap;
    }
    .title,
    .search {
      margin: 0 8px 24px;
    }
    .title {
      width: 40%;
    }
    .title h2 {
      font-size: 32px;
    }
    .search {
      width: 60%;
    }
    .my-modal {
      display: flex;
      align-items: end;
    }
    .sumChar {
      width: 40%;
    }
    .scrollbar {
      margin-top: 0;
      margin-left: 68px;
    }
  }
</style>

<script>
  import Message from "../components/_Yuan/MsgModale.vue";
  import Comment from "../components/_Yuan/CmtModale.vue";
  import axios from "axios";
  export default {
    components: {
      Message,
      Comment,
    },
    data() {
      return {
        data: [],
      };
    },
    created: function () {
      const api = "https://bs-howard.github.io/Homework/fake-room-data.json";
      axios
        .get(api)
        .then((response) => {
          this.data = response.data;
        })
        .catch((error) => {
          console.log(error);
        });
    },
  };
</script>