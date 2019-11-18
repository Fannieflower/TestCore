using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	
	
	public class PurchaseOrderModelResult {
		
		///<summary>
		/// 响应码:0-成功;其他失败
		///</summary>
		
		private int? code_;
		
		///<summary>
		/// 响应信息
		///</summary>
		
		private string msg_;
		
		///<summary>
		/// 采购订单清单
		///</summary>
		
		private List<com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel> purchaseOrderModelList_;
		
		///<summary>
		/// 分页信息
		///</summary>
		
		private com.vip.xstore.cc.bulkbuying.model.PaginationModel pagination_;
		
		public int? GetCode(){
			return this.code_;
		}
		
		public void SetCode(int? value){
			this.code_ = value;
		}
		public string GetMsg(){
			return this.msg_;
		}
		
		public void SetMsg(string value){
			this.msg_ = value;
		}
		public List<com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel> GetPurchaseOrderModelList(){
			return this.purchaseOrderModelList_;
		}
		
		public void SetPurchaseOrderModelList(List<com.vip.xstore.cc.bulkbuying.service.PurchaseOrderModel> value){
			this.purchaseOrderModelList_ = value;
		}
		public com.vip.xstore.cc.bulkbuying.model.PaginationModel GetPagination(){
			return this.pagination_;
		}
		
		public void SetPagination(com.vip.xstore.cc.bulkbuying.model.PaginationModel value){
			this.pagination_ = value;
		}
		
	}
	
}