<template>
  <div class="row requiredInfo">
    <h3>旅程必填資訊</h3>
    <div class="col-9">
      <p>傳訊息給房東</p>
      <p>告訴房東您旅行的目的和入住時間。</p>
    </div>
    <div class="col-3">
      <div
        class="btn"
        type="button"
        data-bs-toggle="offcanvas"
        data-bs-target="#message"
        aria-controls="message"
      >
        新增
      </div>
    </div>
  </div>

  <div
    class="offcanvas offcanvas-bottom messageOffcanvas"
    tabindex="-1"
    id="message"
    aria-labelledby="messageLabel"
  >
    <div class="offcanvas-header">
      <button
        type="button"
        class="btn-close text-reset"
        data-bs-dismiss="offcanvas"
        aria-label="Close"
      ></button>
      <h5 class="offcanvas-title" id="messageLabel">傳訊息給房東</h5>
    </div>
    <div class="offcanvas-body small">
      <div class="row">
        <p>傳訊息給房東</p>
        <p>告訴房東您旅行的目的和入住時間。</p>
      </div>
      <div class="row">
        <div class="col-1">
          <img src="https://picsum.photos/100/100/?random=1" />
        </div>
        <div class="col-11">
          <p class="name">YOS</p>
          <p class="time">加入時間:2020</p>
        </div>
      </div>
      <textarea
        class="form-control"
        id="exampleFormControlTextarea1"
      ></textarea>
    </div>
    <div class="offcanvas-footer">
      <div class="btn btn-dark">儲存</div>
    </div>
  </div>
</template>
<style lang="scss" scoped>
//#region 共用
.requiredInfo > .col-9,
.offcanvas-body > .row {
  p:nth-of-type(1) {
    font-weight: 500;
  }
  p:nth-of-type(2) {
    color: #717171;
  }
}
//#endregion
.requiredInfo {
  .col-9 {
    p {
      font-size: 16px;
      padding: 10px 0;
    }
  }
  .col-3 {
    text-align: end;
    padding-right: 0;
    .btn {
      padding: 5 20px;
      border: 1px solid #717171;
      font-weight: 500;
      border-radius: 10px;
    }
  }
}
.messageOffcanvas {
  .offcanvas-body {
    .row:nth-of-type(1) {
      margin-bottom: 10px;
      p {
        font-size: 14px;
        padding: 5px;
      }
    }
    .row:nth-of-type(2) {
      font-size: 15px;
      padding: 10px 0;
      .col-1 {
        img {
          width: 40px;
          height: 40px;
          border-radius: 50%;
        }
      }
      .col-11 {
        padding-left: 20px;
        .name {
          font-weight: 500;
        }
        .time {
          padding-top: 5px;
        }
      }
    }
    textarea {
      height: 200px;
      resize: none;
      border-radius: 10px;
    }
  }
  .offcanvas-footer {
    padding: 25px;
    .btn {
      width: 100%;
      text-align: center;
      font-size: 18px;
      padding: 10px 0;
      border-radius: 10px;
    }
  }
}
</style>
<script>
export default {};
</script>