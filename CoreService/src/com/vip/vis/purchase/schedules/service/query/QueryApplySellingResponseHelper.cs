using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vis.purchase.schedules.service.query{
	
	
	
	public class QueryApplySellingResponseHelper : TBeanSerializer<QueryApplySellingResponse>
	{
		
		public static QueryApplySellingResponseHelper OBJ = new QueryApplySellingResponseHelper();
		
		public static QueryApplySellingResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryApplySellingResponse structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("applySellingDataList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vis.purchase.schedules.service.query.ApplySellingData> value;
						
						value = new List<com.vip.vis.purchase.schedules.service.query.ApplySellingData>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vis.purchase.schedules.service.query.ApplySellingData elem0;
								
								elem0 = new com.vip.vis.purchase.schedules.service.query.ApplySellingData();
								com.vip.vis.purchase.schedules.service.query.ApplySellingDataHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetApplySellingDataList(value);
					}
					
					
					
					
					
					if ("pageSize".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPageSize(value);
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
		
		
		public void Write(QueryApplySellingResponse structs, Protocol oprot){
			
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
			
			
			if(structs.GetApplySellingDataList() != null) {
				
				oprot.WriteFieldBegin("applySellingDataList");
				
				oprot.WriteListBegin();
				foreach(com.vip.vis.purchase.schedules.service.query.ApplySellingData _item0 in structs.GetApplySellingDataList()){
					
					
					com.vip.vis.purchase.schedules.service.query.ApplySellingDataHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPageSize() != null) {
				
				oprot.WriteFieldBegin("pageSize");
				oprot.WriteI32((int)structs.GetPageSize()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(QueryApplySellingResponse bean){
			
			
		}
		
	}
	
}