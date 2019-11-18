using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.sce.vlg.osp.wms.service{
	
	
	
	
	
	public class GetOutShipContainerResultResponse {
		
		///<summary>
		/// 请求返回header信息
		///</summary>
		
		private com.vip.sce.vlg.osp.wms.service.GetHeader header_;
		
		///<summary>
		/// 请求返回body信息
		///</summary>
		
		private com.vip.sce.vlg.osp.wms.service.GetOutShipContainerResultBodyResponse body_;
		
		public com.vip.sce.vlg.osp.wms.service.GetHeader GetHeader(){
			return this.header_;
		}
		
		public void SetHeader(com.vip.sce.vlg.osp.wms.service.GetHeader value){
			this.header_ = value;
		}
		public com.vip.sce.vlg.osp.wms.service.GetOutShipContainerResultBodyResponse GetBody(){
			return this.body_;
		}
		
		public void SetBody(com.vip.sce.vlg.osp.wms.service.GetOutShipContainerResultBodyResponse value){
			this.body_ = value;
		}
		
	}
	
}