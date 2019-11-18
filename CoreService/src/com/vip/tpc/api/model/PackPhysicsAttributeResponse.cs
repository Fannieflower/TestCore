using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.tpc.api.model{
	
	
	
	
	
	public class PackPhysicsAttributeResponse {
		
		///<summary>
		/// 请求头
		///</summary>
		
		private com.vip.tpc.api.model.common.TpcResponseHeader header_;
		
		///<summary>
		/// 响应对象列表
		///</summary>
		
		private List<com.vip.tpc.api.model.PackPhysicsAttr> packPhysicsAttrs_;
		
		public com.vip.tpc.api.model.common.TpcResponseHeader GetHeader(){
			return this.header_;
		}
		
		public void SetHeader(com.vip.tpc.api.model.common.TpcResponseHeader value){
			this.header_ = value;
		}
		public List<com.vip.tpc.api.model.PackPhysicsAttr> GetPackPhysicsAttrs(){
			return this.packPhysicsAttrs_;
		}
		
		public void SetPackPhysicsAttrs(List<com.vip.tpc.api.model.PackPhysicsAttr> value){
			this.packPhysicsAttrs_ = value;
		}
		
	}
	
}