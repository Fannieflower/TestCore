using Newtonsoft.Json;
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
        public string SearchGoodsList()
        {
            try
            {
                com.vip.adp.api.open.service.UnionGoodsServiceHelper.UnionGoodsServiceClient client = new com.vip.adp.api.open.service.UnionGoodsServiceHelper.UnionGoodsServiceClient();
                Osp.Sdk.Context.InvocationContext invocationContext = Osp.Sdk.Context.Factory.GetInstance();
                invocationContext.SetAppKey("b598506a");
                invocationContext.SetAppSecret("2B73B56F3B070F339A3BA6E63B8767BD");
                invocationContext.SetAppURL("http://sandbox.vipapis.com/");//沙箱环境
                //invocationContext.SetAppURL("https://gw.vipapis.com/"); //正式环境
                invocationContext.SetLanguage("zh");

                com.vip.adp.api.open.service.QueryGoodsRequest request1 = new com.vip.adp.api.open.service.QueryGoodsRequest();
                request1.SetKeyword("衣服");
                request1.SetFieldName("fieldName");
                request1.SetOrder(1);//排序顺序：0-正序，1-逆序，默认正序
                request1.SetPage(1);
                request1.SetPageSize(20);//页面大小：默认20
                request1.SetRequestId("requestId");//请求id：UUID，调用方自行定义，用于追踪请求
                //request1.SetPriceStart("");//价格区间---start
                //request1.SetPriceEnd("");

                /**
                 * 以下参数sdk已经不提供了
                //request1.SetQueryReputation(false);//是否查询商品评价信息:默认不查询，该数据在详情页有返回，没有特殊需求，建议不查询，影响接口性能
                //request1.SetQueryStoreServiceCapability(true);//是否查询店铺服务能力信息：默认不查询，该数据在详情页有返回，没有特殊需求，建议不查询，影响接口性能
                */
                var resp=client.query(request1);
                return JsonConvert.SerializeObject(resp);
            }
            catch (Osp.Sdk.Exception.OspException ex)
            {
                return ex.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return "";
        }

    }
}
