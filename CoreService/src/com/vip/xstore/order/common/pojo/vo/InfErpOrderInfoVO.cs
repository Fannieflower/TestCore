using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.order.common.pojo.vo{
	
	
	
	
	
	public class InfErpOrderInfoVO {
		
		///<summary>
		/// 接口表单头信息
		///</summary>
		
		private com.vip.xstore.order.common.pojo.vo.InfErpMRetailVO infErpMRetail_;
		
		///<summary>
		/// 接口表商品明细
		///</summary>
		
		private List<com.vip.xstore.order.common.pojo.vo.InfErpMRetailItemVO> infErpMRetailItemList_;
		
		///<summary>
		/// 接口表支付信息
		///</summary>
		
		private List<com.vip.xstore.order.common.pojo.vo.InfErpMRetailPayItemVO> infErpMRetailPayItemList_;
		
		public com.vip.xstore.order.common.pojo.vo.InfErpMRetailVO GetInfErpMRetail(){
			return this.infErpMRetail_;
		}
		
		public void SetInfErpMRetail(com.vip.xstore.order.common.pojo.vo.InfErpMRetailVO value){
			this.infErpMRetail_ = value;
		}
		public List<com.vip.xstore.order.common.pojo.vo.InfErpMRetailItemVO> GetInfErpMRetailItemList(){
			return this.infErpMRetailItemList_;
		}
		
		public void SetInfErpMRetailItemList(List<com.vip.xstore.order.common.pojo.vo.InfErpMRetailItemVO> value){
			this.infErpMRetailItemList_ = value;
		}
		public List<com.vip.xstore.order.common.pojo.vo.InfErpMRetailPayItemVO> GetInfErpMRetailPayItemList(){
			return this.infErpMRetailPayItemList_;
		}
		
		public void SetInfErpMRetailPayItemList(List<com.vip.xstore.order.common.pojo.vo.InfErpMRetailPayItemVO> value){
			this.infErpMRetailPayItemList_ = value;
		}
		
	}
	
}