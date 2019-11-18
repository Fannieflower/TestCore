using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.user.face.service{
	
	
	
	
	
	public class XstoreCameraStateLogListResult {
		
		///<summary>
		/// 摄像头列表信息
		///</summary>
		
		private List<com.vip.xstore.user.face.service.XstoreBoxStateLogModel> xstoreBoxStateLogs_;
		
		///<summary>
		/// 符合查询条件的总条数
		///</summary>
		
		private int? total_;
		
		///<summary>
		/// 分页信息
		///</summary>
		
		private com.vip.xstore.user.face.service.common.PageInfo pageInfo_;
		
		public List<com.vip.xstore.user.face.service.XstoreBoxStateLogModel> GetXstoreBoxStateLogs(){
			return this.xstoreBoxStateLogs_;
		}
		
		public void SetXstoreBoxStateLogs(List<com.vip.xstore.user.face.service.XstoreBoxStateLogModel> value){
			this.xstoreBoxStateLogs_ = value;
		}
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		public com.vip.xstore.user.face.service.common.PageInfo GetPageInfo(){
			return this.pageInfo_;
		}
		
		public void SetPageInfo(com.vip.xstore.user.face.service.common.PageInfo value){
			this.pageInfo_ = value;
		}
		
	}
	
}