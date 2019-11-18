using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.ordererp.api.response{
	
	
	
	
	
	public class AddInfErpOrderInfoResp {
		
		///<summary>
		/// 返回结果
		///</summary>
		
		private com.vip.xstore.order.common.pojo.vo.Result result_;
		
		///<summary>
		/// 成功入库的外部订单号列表，不代表成功处理了，转换至唯品会订单格式，在另外个任务中进行
		///</summary>
		
		private List<string> successExtOrderSns_;
		
		///<summary>
		/// 入库失败的外部订单号列表
		///</summary>
		
		private List<vipapis.xstore.cc.ordererp.api.response.AddFailMsgVO> failMsgList_;
		
		public com.vip.xstore.order.common.pojo.vo.Result GetResult(){
			return this.result_;
		}
		
		public void SetResult(com.vip.xstore.order.common.pojo.vo.Result value){
			this.result_ = value;
		}
		public List<string> GetSuccessExtOrderSns(){
			return this.successExtOrderSns_;
		}
		
		public void SetSuccessExtOrderSns(List<string> value){
			this.successExtOrderSns_ = value;
		}
		public List<vipapis.xstore.cc.ordererp.api.response.AddFailMsgVO> GetFailMsgList(){
			return this.failMsgList_;
		}
		
		public void SetFailMsgList(List<vipapis.xstore.cc.ordererp.api.response.AddFailMsgVO> value){
			this.failMsgList_ = value;
		}
		
	}
	
}