<template>
  <div class="row yourTrip">
    <h3>你的旅程</h3>
    <div class="col-9">
      <p>日期</p>
      <p v-if="getDuring">
        {{ $store.state.date.start }} - {{ $store.state.date.end }}
      </p>
    </div>
    <div class="col-3">
      <div
        class="btn"
        type="button"
        data-bs-toggle="offcanvas"
        data-bs-target="#during"
        aria-controls="during"
      >
        編輯
      </div>
    </div>
    <div class="col-9">
      <p>房客人數</p>
      <p v-if="getPeople">
        {{ $store.state.adult + $store.state.child }}位,{{
          $store.state.toddler
        }}名嬰幼兒
      </p>
    </div>
    <div class="col-3">
      <div
        class="btn"
        type="button"
        data-bs-toggle="offcanvas"
        data-bs-target="#people"
        aria-controls="people"
      >
        編輯
      </div>
    </div>
  </div>

  <div
    class="offcanvas offcanvas-bottom duringOffcanvas"
    tabindex="-1"
    id="during"
    aria-labelledby="duringLabel"
  >
    <div class="offcanvas-header">
      <button
        type="button"
        class="btn-close text-reset"
        data-bs-dismiss="offcanvas"
        aria-label="Close"
      ></button>
      <h5 class="offcanvas-title" id="duringLabel" v-if="getDuring">
        {{ $store.state.date.start }} - {{ $store.state.date.end }}
      </h5>
    </div>
    <div class="offcanvas-body small">
      <SubDate></SubDate>
    </div>
    <div class="offcanvas-footer">
      <div
        class="btn"
        href="#"
        @click.prevent="$store.state.date = new Date()"
        @click="getDuring = false"
      >
        清除
      </div>
      <div
        class="btn btn-dark"
        data-bs-dismiss="offcanvas"
        @click="getDuring = true"
      >
        儲存
      </div>
    </div>
  </div>

  <div
    class="offcanvas offcanvas-bottom peopleOffcanvas"
    tabindex="-1"
    id="people"
    aria-labelledby="peopleLabel"
  >
    <div class="offcanvas-header">
      <button
        type="button"
        class="btn-close text-reset"
        data-bs-dismiss="offcanvas"
        aria-label="Close"
      ></button>
      <h5 class="offcanvas-title" id="peopleLabel" v-if="getPeople">
        {{ $store.state.adult + $store.state.child }}位,{{
          $store.state.toddler
        }}名嬰幼兒
      </h5>
    </div>
    <div class="offcanvas-body small">
      <People></People>
    </div>
    <div class="offcanvas-footer">
      <div
        class="btn btn-dark"
        data-bs-dismiss="offcanvas"
        @click="getPeople = true"
      >
        儲存
      </div>
    </div>
  </div>
</template>

<style lang="scss" scoped>
.yourTrip {
  .col-9 {
    p {
      font-size: 16px;
      padding: 10px 0;
    }
    p:nth-of-type(1) {
      font-weight: 500;
    }
    p:nth-of-type(2) {
      color: #717171;
    }
  }
  .col-3 {
    text-align: end;
    .btn {
      padding: 0;
      font-weight: 500;
      text-decoration: underline;
    }
  }
}
.duringOffcanvas {
  .offcanvas-header {
    padding: 20px 30px;
  }
  .offcanvas-body {
    padding-top: 30px;
    padding-bottom: 0;
  }
  .offcanvas-footer {
    display: flex;
    justify-content: space-between;
    padding: 20px 40px;
  }
}
.peopleOffcanvas {
  .offcanvas-header {
    padding: 20px 25px;
  }
  .offcanvas-body {
    padding: 0;
    .people {
      font-weight: 400;
    }
  }
  .offcanvas-footer {
    padding: 20px 40px;
    text-align: end;
  }
}
</style>

<script>
import SubDate from "../Subscribe/SubDate.vue";
import People from "../Room/People.vue";
export default {
  data() {
    return {
      getDuring: false,
      getPeople: false,
    };
  },
  components: {
    SubDate,
    People,
  },
};
</script>