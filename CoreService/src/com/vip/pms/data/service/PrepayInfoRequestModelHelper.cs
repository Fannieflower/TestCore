using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class PrepayInfoRequestModelHelper : TBeanSerializer<PrepayInfoRequestModel>
	{
		
		public static PrepayInfoRequestModelHelper OBJ = new PrepayInfoRequestModelHelper();
		
		public static PrepayInfoRequestModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PrepayInfoRequestModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("prepayMainNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPrepayMainNo(value);
					}
					
					
					
					
					
					if ("merchandiseIdList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<long?> value;
						
						value = new List<long?>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								long elem0;
								elem0 = iprot.ReadI64(); 
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetMerchandiseIdList(value);
					}
					
					
					
					
					
					if ("firstBeginTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetFirstBeginTime(value);
					}
					
					
					
					
					
					if ("firstEndTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetFirstEndTime(value);
					}
					
					
					
					
					
					if ("merchandiseModelList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PrepayMerchandiseModel> value;
						
						value = new List<com.vip.pms.data.service.PrepayMerchandiseModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PrepayMerchandiseModel elem1;
								
								elem1 = new com.vip.pms.data.service.PrepayMerchandiseModel();
								com.vip.pms.data.service.PrepayMerchandiseModelHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetMerchandiseModelList(value);
					}
					
					
					
					
					
					if ("opType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetOpType(value);
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
		
		
		public void Write(PrepayInfoRequestModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPrepayMainNo() != null) {
				
				oprot.WriteFieldBegin("prepayMainNo");
				oprot.WriteString(structs.GetPrepayMainNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("prepayMainNo can not be null!");
			}
			
			
			if(structs.GetMerchandiseIdList() != null) {
				
				oprot.WriteFieldBegin("merchandiseIdList");
				
				oprot.WriteListBegin();
				foreach(long _item0 in structs.GetMerchandiseIdList()){
					
					oprot.WriteI64((long)_item0); 
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFirstBeginTime() != null) {
				
				oprot.WriteFieldBegin("firstBeginTime");
				oprot.WriteI64((long)structs.GetFirstBeginTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFirstEndTime() != null) {
				
				oprot.WriteFieldBegin("firstEndTime");
				oprot.WriteI64((long)structs.GetFirstEndTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMerchandiseModelList() != null) {
				
				oprot.WriteFieldBegin("merchandiseModelList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PrepayMerchandiseModel _item0 in structs.GetMerchandiseModelList()){
					
					
					com.vip.pms.data.service.PrepayMerchandiseModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOpType() != null) {
				
				oprot.WriteFieldBegin("opType");
				oprot.WriteI32((int)structs.GetOpType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PrepayInfoRequestModel bean){
			
			
		}
		
	}
	
}