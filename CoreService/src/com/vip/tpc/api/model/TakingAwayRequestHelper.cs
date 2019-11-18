using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
using vipapis_S = vipapis;
namespace com.vip.tpc.api.model{
	
	
	
	public class TakingAwayRequestHelper : TBeanSerializer<TakingAwayRequest>
	{
		
		public static TakingAwayRequestHelper OBJ = new TakingAwayRequestHelper();
		
		public static TakingAwayRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TakingAwayRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("type".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetType(value);
					}
					
					
					
					
					
					if ("packs".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis_S.tpc.service.Pack> value;
						
						value = new List<vipapis_S.tpc.service.Pack>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis_S.tpc.service.Pack elem0;
								
								elem0 = new vipapis_S.tpc.service.Pack();
								vipapis_S.tpc.service.PackHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPacks(value);
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
		
		
		public void Write(TakingAwayRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderSn can not be null!");
			}
			
			
			if(structs.GetType() != null) {
				
				oprot.WriteFieldBegin("type");
				oprot.WriteString(structs.GetType());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("type can not be null!");
			}
			
			
			if(structs.GetPacks() != null) {
				
				oprot.WriteFieldBegin("packs");
				
				oprot.WriteListBegin();
				foreach(vipapis_S.tpc.service.Pack _item0 in structs.GetPacks()){
					
					
					vipapis_S.tpc.service.PackHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("packs can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TakingAwayRequest bean){
			
			
		}
		
	}
	
}