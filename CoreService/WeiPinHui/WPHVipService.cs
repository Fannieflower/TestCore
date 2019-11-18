using Osp.Sdk.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreService.WeiPinHui
{
    /// <summary>
    /// 唯品会
    /// </summary>
    public class WPHVipService
    {
        /// <summary>
        /// query接口
        /// 根据关键词查询商品列表
        /// </summary>
        public void SearchGoodsList()
        {
            try
            {

                com.vip.adp.api.open.service.UnionGoodsServiceHelper.UnionGoodsServiceClient client = new com.vip.adp.api.open.service.UnionGoodsServiceHelper.UnionGoodsServiceClient();
                InvocationContext invocationContext = Factory.GetInstance();
                invocationContext.SetAppKey("your appKey");
                invocationContext.SetAppSecret("your appSecret");
                invocationContext.SetAppURL("");
                invocationContext.SetAccessToken("your accessToken if you need");
                invocationContext.SetLanguage("the language code if you need");


            }
            catch (Osp.Sdk.Exception.OspException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (Exception ex)
            {

            }

        }

    }
}
