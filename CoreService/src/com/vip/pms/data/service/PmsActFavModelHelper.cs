using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class PmsActFavModelHelper : TBeanSerializer<PmsActFavModel>
	{
		
		public static PmsActFavModelHelper OBJ = new PmsActFavModelHelper();
		
		public static PmsActFavModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PmsActFavModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("buy".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetBuy(value);
					}
					
					
					
					
					
					if ("cut".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetCut(value);
					}
					
					
					
					
					
					if ("pmsActGiftInfoList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsActGiftInfoModel> value;
						
						value = new List<com.vip.pms.data.service.PmsActGiftInfoModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsActGiftInfoModel elem0;
								
								elem0 = new com.vip.pms.data.service.PmsActGiftInfoModel();
								com.vip.pms.data.service.PmsActGiftInfoModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPmsActGiftInfoList(value);
					}
					
					
					
					
					
					if ("stepStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetStepStatus(value);
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
		
		
		public void Write(PmsActFavModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBuy() != null) {
				
				oprot.WriteFieldBegin("buy");
				oprot.WriteDouble((double)structs.GetBuy());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("buy can not be null!");
			}
			
			
			if(structs.GetCut() != null) {
				
				oprot.WriteFieldBegin("cut");
				oprot.WriteDouble((double)structs.GetCut());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("cut can not be null!");
			}
			
			
			if(structs.GetPmsActGiftInfoList() != null) {
				
				oprot.WriteFieldBegin("pmsActGiftInfoList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsActGiftInfoModel _item0 in structs.GetPmsActGiftInfoList()){
					
					
					com.vip.pms.data.service.PmsActGiftInfoModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStepStatus() != null) {
				
				oprot.WriteFieldBegin("stepStatus");
				oprot.WriteByte((byte)structs.GetStepStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PmsActFavModel bean){
			
			
		}
		
	}
	
}