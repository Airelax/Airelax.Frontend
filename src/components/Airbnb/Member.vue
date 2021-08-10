<template>
    <div id="banner"></div>
    <div class="List-pill rounded-pill" @click="show">
        <div class="ham"></div>
            <i class="fas fa-user-circle"></i>
            <ul class="list-group">
                <li class="list-group-item border-0 rounded-top">
                    <a href="#">
                        <strong>訊息</strong>
                    </a>
                </li>
                <li class="list-group-item border-0">
                    <a href="#">
                        <strong>通知</strong>
                    </a>
                </li>
                <li class="list-group-item border-0">
                    <a href="#">
                        <strong>旅程</strong>
                    </a>
                </li>
                <li class="list-group-item border-0 border-bottom">
                    <a href="#">
                        <strong>心願單</strong>
                    </a>
                </li>
                <li class="list-group-item border-0">
                    <a href="#">
                        <strong>管理房源</strong>
                    </a>
                </li>
                <li class="list-group-item border-0">
                    <a href="#">
                        <strong>舉辦體驗</strong>
                    </a>
                </li>
                <li class="list-group-item border-0 border-bottom">
                    <a href="#">
                        <strong>帳號</strong>
                    </a>
                </li>
                <li class="list-group-item border-0">
                    <a href="#">
                        <strong>協助</strong>
                    </a>
                </li>
                <li class="list-group-item border-0 rounded-end">
                    <a href="#">
                        <strong>登出</strong>
                    </a>
                </li>
            </ul>
        </div>
</template>

<script>
export default {
    methods:{
        show(){
            document.querySelector('.list-group').style.display = 'block'
            document.getElementById('banner').style.display = 'block';
            document.getElementById('banner').addEventListener('click',()=>{
                document.querySelector('.list-group').style.display = 'none'
                document.getElementById('banner').style.display = 'none';
            })
        }
    },
    mounted(){
		//下滑fixed
        window.addEventListener("scroll", function() {
            let top = document.documentElement.scrollTop;
			let list = document.querySelector('.List-pill');
            if(top>50){
                list.classList.add('fixed');
            }
            else{
                list.classList.remove('fixed');
            }
        });
	}
}
</script>

<style lang="scss" scoped>
.List-pill{
    background-color: #ffffff;
    width: 77px;
    height: 42px;
    display: flex;
    flex-direction: row;
    align-items: center;
    position: relative;
    cursor: pointer;
    border-radius: 18px;
    &.fixed{
        border: 1px solid #000;
    }
}

.list-group{
    position: absolute;
    top: 53px;
    right: 0;
    width: 225px;
    display: none;
    z-index: 10;
    border-radius: 18px;
    border: 1px solid rgb(202, 202, 202);
    overflow: hidden;
}
.ham {
    display: block;
    content         : '';
    height          : 2px;
    width           : 15px;
    background-color: #222222;
    margin          : auto;
    box-shadow      : 0px 4px 0px #222222,
                    0px -4px 0px #222222;
}
.list-group-item{
    padding: 15px;
}
.list-group li a{
    text-decoration: none;
    color: black;
}

.list-group li:hover{
    background-color: #E7F0EB;
}
.list-group li{
    font-size: .5rem;
    line-height:18px;
}
i{
    width: 2rem;
    font-size: 1.5rem;
}
#banner {
  display: none;
  position: absolute;
  width: 100vw;
  height: 100vh;
  z-index: 9;
}
strong{
    font-weight: 400;
    font-size: 1rem;
}
</style>