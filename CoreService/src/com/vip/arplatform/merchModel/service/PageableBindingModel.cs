using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.arplatform.merchModel.service{
	
	
	
	
	
	public class PageableBindingModel {
		
		///<summary>
		/// 起始页
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 当前页记录数
		///</summary>
		
		private int? limit_;
		
		///<summary>
		/// 总记录数
		///</summary>
		
		private int? total_;
		
		///<summary>
		/// 记录列表
		///</summary>
		
		private List<com.vip.arplatform.merchModel.service.BindingModel> mdList_;
		
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		public int? GetLimit(){
			return this.limit_;
		}
		
		public void SetLimit(int? value){
			this.limit_ = value;
		}
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		public List<com.vip.arplatform.merchModel.service.BindingModel> GetMdList(){
			return this.mdList_;
		}
		
		public void SetMdList(List<com.vip.arplatform.merchModel.service.BindingModel> value){
			this.mdList_ = value;
		}
		
	}
	
}