using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.ofc.response.vop{
	
	
	
	
	
	public class WmsUpdateOrderStatusResp {
		
		///<summary>
		/// 返回结果
		///</summary>
		
		private com.vip.order.common.pojo.order.result.Result result_;
		
		///<summary>
		/// wms接口id列表
		///</summary>
		
		private List<string> wmsIdList_;
		
		public com.vip.order.common.pojo.order.result.Result GetResult(){
			return this.result_;
		}
		
		public void SetResult(com.vip.order.common.pojo.order.result.Result value){
			this.result_ = value;
		}
		public List<string> GetWmsIdList(){
			return this.wmsIdList_;
		}
		
		public void SetWmsIdList(List<string> value){
			this.wmsIdList_ = value;
		}
		
	}
	
}