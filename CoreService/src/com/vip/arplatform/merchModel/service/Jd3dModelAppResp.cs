using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.arplatform.merchModel.service{
	
	
	
	
	
	public class Jd3dModelAppResp {
		
		///<summary>
		/// channel
		///</summary>
		
		private string channel_;
		
		///<summary>
		/// spu
		///</summary>
		
		private string spu_;
		
		///<summary>
		/// vendorId
		///</summary>
		
		private int? vendorId_;
		
		///<summary>
		/// 3d 模型数据
		///</summary>
		
		private List<com.vip.arplatform.merchModel.service.Jd3dModel> items_;
		
		public string GetChannel(){
			return this.channel_;
		}
		
		public void SetChannel(string value){
			this.channel_ = value;
		}
		public string GetSpu(){
			return this.spu_;
		}
		
		public void SetSpu(string value){
			this.spu_ = value;
		}
		public int? GetVendorId(){
			return this.vendorId_;
		}
		
		public void SetVendorId(int? value){
			this.vendorId_ = value;
		}
		public List<com.vip.arplatform.merchModel.service.Jd3dModel> GetItems(){
			return this.items_;
		}
		
		public void SetItems(List<com.vip.arplatform.merchModel.service.Jd3dModel> value){
			this.items_ = value;
		}
		
	}
	
}