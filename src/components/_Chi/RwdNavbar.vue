<template>
    <div id="nav"  v-show="isShow" @scroll="isShow=!isShow">
        <div class="LinkGroup col-10">

            <div class="search">

                <div class="col-12 linkItem">
                    <a class="col-12">
                    <img :src="require('@/assets/pic/RwdNavbar/search.svg')">
                    </a>
                </div>
                <div class="col-12 linkItemText">
                    <a class="col-12">探索</a>
                </div>
            </div>

            <div class="wish">
                <div class="col-12 linkItem">
                    <a class="col-12"><img :src="require('@/assets/pic/RwdNavbar/mail.svg')"></a> 
                </div>
                <div class="col-12 linkItemText">
                    <a>心願單</a> 
                </div>
            </div>

            <div class="trip">
                <div class="col-12 linkItem">
                    <a class="col-12"><img :src="require('@/assets/pic/RwdNavbar/airbnblogo.svg')"></a> 
                </div>
                <div class="col-12 linkItemText">
                    <a>旅程</a> 
                </div>
            </div>

            <div class="email">
                <div class="col-12 linkItem">
                    <a class="col-12"><img :src="require('@/assets/pic/RwdNavbar/mail.svg')"></a> 
                </div>
                <div class="col-12 linkItemText">
                    <a>收件匣</a> 
                </div>
            </div>

            <div class="person">
                <div class="col-12 linkItem">
                    <a class="col-12"><img :src="require('@/assets/pic/RwdNavbar/personData.svg')"></a> 
                </div>
                <div class="col-12 linkItemText">
                    <a>個人資料</a> 
                </div>
            </div>
        </div>
        
    </div>
    
</template>


<script>
export default {
    data(){
        return{
            isShow:true
        }
    },
    methods:{
        scrollEvevt(){
            if (window.scrollY >= document.body.scrollHeight){
                this.isShow=false
            }
        }
    },
}
</script>


<style scoped lang="scss">
#nav{
    font-family: Avenir, Helvetica, Arial, sans-serif;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    text-align: center;
    padding: 0;
    position: fixed;
    bottom: 0;
    right: 0;
    left: 0;
    display: flex;
    justify-content: center;
    

    .LinkGroup{
        display: flex;
        justify-content: space-around;
        

        .search,.wish,.trip,.email,.person{
            width: 20%;
            background-color: #fff;
            cursor: pointer;
            display: flex;
            flex-direction: column;
            height: 64px;
            justify-content: center;
            
            
            .linkItem{
                a{
                    display: flex;;
                    color:#b0b0b0;
                    justify-content: center;
                    img{
                        color:#b0b0b0;
                        width: 30px;
                        fill: currentColor;
                    }
                    &.a-exact-active {
                        img{
                            color: #ff385c;
                        }
                        
                    }
                    
                }
            }

            .linkItemText{
                    a{
                        display: block;
                        font-weight: bold;
                        color:#b0b0b0;
                        text-decoration: none;
                        width: 100%;
                        white-space:nowrap;
                        &.a-exact-active {
                            color: #222222;
                        }
                    }
            }
        }


            

        
        .search:hover{
            .linkItem{
                a{
                    
                    img{
                        color: #ff385c;
                    }
                    color: #ff385c;
                }
                
            }

            .linkItemText{
                a{
                    color: #222222;
                }
                
            }
        }

        .wish:hover{
            .linkItem{
                a{
                    img{
                        color: #ff385c;
                    }
                    color: #ff385c;
                }
                
            }

            .linkItemText{
                a{
                    color: #222222;
                }
            }
        }

        .trip:hover{
            .linkItem{
                a{
                    color: #ff385c;
                }
            }

            .linkItemText{
                a{
                    color: #222222;
                }
            }
        }

        .email:hover{
            .linkItem{
                a{
                    color: #ff385c;
                }
                
            }

            .linkItemText{
                a{
                    color: #222222;
                }
            }
        }

        .person:hover{
            .linkItem{
                a{
                    color: #ff385c;
                }
            }

            .linkItemText{
                a{
                    color: #222222;
                }
            }
        }
    }
}

@media screen and (min-width:768px) {
    #nav{
        display: none;
    }
}


</style>
