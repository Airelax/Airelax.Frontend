<template>
  <h1>Yuan</h1>
  <div v-if="data" class="my-container">
    <div class="summary">
      <CommentSummary :v-if="data" :data="data"></CommentSummary>
    </div>
    <div class="sum-char container-fluid">
      <div class="row">
        <Comment :rank="data.rank"></Comment>
      </div>
    </div>
    <div class="scrollbar container-fluid">
      <Message :com="data.comments"></Message>
    </div>
  </div>
  <div class="btn-box">
    <button class="btn-modal" v-if="data.comments">
      顯示全部{{ data.comments.length }}則評價
    </button>
  </div>
</template>

<style scoped>
.summary {
  margin-bottom: 32px;
}

.row {
  width: 100%;
}

.my-container * {
  font-family: Circular, -apple-system, BlinkMacSystemFont, Roboto,
    "Helvetica Neue", sans-serif;
  color: #222;
  /* outline: 1px solid red; */
}
.my-container {
  overflow: auto;
  padding: 32px 0 24px;
  margin: 0 24px;
  border-top: 1px solid rgb(221, 221, 221);
}
.my-container::-webkit-scrollbar {
  display: none;
}

.sum-char {
  display: none;
}
.scrollbar {
  width: fit-content;
  display: flex;
}
.btn-box {
  border-bottom: 1px solid rgb(221, 221, 221);
  margin: 0 24px;
}
.btn-modal {
  width: 100%;
  height: 48px;
  font-weight: 600;
  background-color: transparent;
  border: 1px solid #222;
  border-radius: 8px;
  padding: 13px 23px;
  margin-bottom: 24px;
  animation: AnimEnds 0.125s;
}
.btn-modal:focus {
  background-color: #f7f7f7;
  text-decoration: underline;
  animation: AnimStarts 0.125s;
  animation-fill-mode: forwards;
}

.container-fluid {
  padding: 0;
}
@keyframes AnimStarts {
  0% {
    width: 100%;
    height: 48px;
    font-size: 16px;
    margin-top: 0;
    margin-bottom: 24px;
  }
  100% {
    width: 95%;
    height: 44px;
    font-size: 14px;
    margin-top: 2px;
    margin-bottom: 26px;
  }
}
@keyframes AnimEnds {
  0% {
    width: 95%;
    height: 44px;
    font-size: 14px;
    margin-top: 2px;
    margin-bottom: 26px;
  }
  100% {
    width: 100%;
    height: 48px;
    font-size: 16px;
    margin-top: 0;
    margin-bottom: 24px;
  }
}
@media screen and (min-width: 768px) {
  .my-container {
    margin: 0 40px;
  }
  .sum-char {
    width: 100%;
    display: flex;
  }
  .scrollbar {
    width: 100%;
    display: block;
    margin-top: 32px;
  }
  .btn-box {
    margin: 0 40px;
  }
  .btn-modal {
    width: 169px;
    display: block;
  }
  @keyframes AnimStarts {
    0% {
      width: 169px;
      height: 48px;
      font-size: 16px;
      margin-top: 0;
      margin-bottom: 24px;
      margin-left: 0;
    }
    100% {
      width: 163px;
      height: 44px;
      font-size: 15px;
      margin-top: 2px;
      margin-bottom: 26px;
      margin-left: 3px;
    }
  }
  @keyframes AnimEnds {
    0% {
      width: 163px;
      height: 44px;
      font-size: 15px;
      margin-top: 2px;
      margin-bottom: 26px;
      margin-left: 3px;
    }
    100% {
      width: 169px;
      height: 48px;
      font-size: 16px;
      margin-top: 0;
      margin-bottom: 24px;
      margin-left: 0;
    }
  }
}
@media screen and (min-width: 1200px) {
  .my-container {
    margin: 0 80px;
  }
  .scrollbar {
    display: flex;
    flex-wrap: wrap;
  }
  .btn-box {
    margin: 0 80px;
  }
}
</style>

<script>
import Message from "../components/_Yuan/Messages.vue";
import Comment from "../components/_Yuan/Comments.vue";
import CommentSummary from "../components/_Yuan/CommentSummary.vue";
import axios from "axios";
export default {
  components: {
    Message,
    Comment,
    CommentSummary,
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