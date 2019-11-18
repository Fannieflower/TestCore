using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vis.purchase.schedules.service.query{
	
	
	
	
	
	public class QueryScheduleInfoResponse {
		
		///<summary>
		/// 返回码
		///</summary>
		
		private int? code_;
		
		///<summary>
		/// 返回信息
		///</summary>
		
		private string msg_;
		
		///<summary>
		/// 总数
		///</summary>
		
		private int? totalNum_;
		
		///<summary>
		/// 采购协议数据结构
		///</summary>
		
		private List<com.vip.vis.purchase.schedules.service.query.ScheduleInfoData> scheduleInfoDataList_;
		
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
		public int? GetTotalNum(){
			return this.totalNum_;
		}
		
		public void SetTotalNum(int? value){
			this.totalNum_ = value;
		}
		public List<com.vip.vis.purchase.schedules.service.query.ScheduleInfoData> GetScheduleInfoDataList(){
			return this.scheduleInfoDataList_;
		}
		
		public void SetScheduleInfoDataList(List<com.vip.vis.purchase.schedules.service.query.ScheduleInfoData> value){
			this.scheduleInfoDataList_ = value;
		}
		
	}
	
}