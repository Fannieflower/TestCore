using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vis.purchase.schedules.service.query{
	
	
	
	public class QueryScheduleByShopCodeResponseHelper : TBeanSerializer<QueryScheduleByShopCodeResponse>
	{
		
		public static QueryScheduleByShopCodeResponseHelper OBJ = new QueryScheduleByShopCodeResponseHelper();
		
		public static QueryScheduleByShopCodeResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryScheduleByShopCodeResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("code".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetCode(value);
					}
					
					
					
					
					
					if ("msg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMsg(value);
					}
					
					
					
					
					
					if ("totalNum".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTotalNum(value);
					}
					
					
					
					
					
					if ("scheduleByShopCodeList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vis.purchase.schedules.service.query.ScheduleByShopCode> value;
						
						value = new List<com.vip.vis.purchase.schedules.service.query.ScheduleByShopCode>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vis.purchase.schedules.service.query.ScheduleByShopCode elem0;
								
								elem0 = new com.vip.vis.purchase.schedules.service.query.ScheduleByShopCode();
								com.vip.vis.purchase.schedules.service.query.ScheduleByShopCodeHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetScheduleByShopCodeList(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(QueryScheduleByShopCodeResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCode() != null) {
				
				oprot.WriteFieldBegin("code");
				oprot.WriteI32((int)structs.GetCode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMsg() != null) {
				
				oprot.WriteFieldBegin("msg");
				oprot.WriteString(structs.GetMsg());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotalNum() != null) {
				
				oprot.WriteFieldBegin("totalNum");
				oprot.WriteI32((int)structs.GetTotalNum()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetScheduleByShopCodeList() != null) {
				
				oprot.WriteFieldBegin("scheduleByShopCodeList");
				
				oprot.WriteListBegin();
				foreach(com.vip.vis.purchase.schedules.service.query.ScheduleByShopCode _item0 in structs.GetScheduleByShopCodeList()){
					
					
					com.vip.vis.purchase.schedules.service.query.ScheduleByShopCodeHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(QueryScheduleByShopCodeResponse bean){
			
			
		}
		
	}
	
}